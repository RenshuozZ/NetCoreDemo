namespace KM
{
    using System;
    using System.Collections.Generic;
    //https://blog.csdn.net/chenshibo17/article/details/79933191

    public enum TaskRoleTypeEnum
    {
        IOL = 1,
        VCS = 2,
        EOR = 3,
        JP3 = 4,
    }
    public class MatchTaskModel
    {
        public MatchTaskModel(TaskRoleTypeEnum taskTypeEnum, int weight)
        {
            TaskType = taskTypeEnum;
            Weight = weight;
        }
        public TaskRoleTypeEnum TaskType { get; set; }
        public int Weight { get; set; }
    }
    public class MatchExaminerModel
    {
        public MatchExaminerModel(string examinerNo,params TaskRoleTypeEnum[] availableTaskTypes)
        {
            AvailableTaskTypes = availableTaskTypes;
            ExaminerNo = examinerNo;
        }
        public TaskRoleTypeEnum[] AvailableTaskTypes { get; set; }
        public string ExaminerNo { get; set; }
    }
    public static class KMHelper
    {
        public static readonly int TaskCount = 6;
        public static readonly int INF = 0x3f3f3f3f;
        public static int[][] match_weight = RectangularIntArray(TaskCount, TaskCount); // 记录每个任务和每个考官的权重
        public static int[] ex_task = new int[TaskCount]; // 每个任务的期望值
        public static int[] ex_examiner = new int[TaskCount]; // 每个考官的期望值
        public static bool[] vis_task = new bool[TaskCount]; // 记录每一轮匹配匹配过的任务
        public static bool[] vis_examiner = new bool[TaskCount]; // 记录每一轮匹配匹配过的考官
        public static int[] match = new int[TaskCount]; // 记录每个考官匹配到的任务 如果没有则为-1
        public static int[] slack = new int[TaskCount]; // 记录每个考官如果能被分配任务最少还需要多少期望值

        public static int N = TaskCount;

        public static bool dfs(int task)
        {
            vis_task[task] = true;

            for (int examiner = 0; examiner < N; ++examiner)
            {
                if (vis_examiner[examiner])
                {
                    continue; // 每一轮匹配 每个考官只尝试一次
                }

                int gap = ex_task[task] + ex_examiner[examiner] - match_weight[task][examiner];

                if (gap == 0)
                { // 如果符合要求
                    vis_examiner[examiner] = true;
                    if (match[examiner] == -1 || dfs(match[examiner]))
                    { 
                        // 找到一个没有匹配的考官 或者该考官的任务可以找到其他人
                        match[examiner] = task;
                        return true;
                    }
                }
                else
                {
                    slack[examiner] = Math.Min(slack[examiner], gap); // slack 可以理解为该考官要得到任务的匹配 还需多少期望值 取最小值
                }
            }

            return false;
        }

        public static int KM()
        {
            // 初始每个考官都没有匹配的任务
            //memset(match, -1, sizeof(int)); 
            SetIntArrayAllValue(match, -1);
            // 初始每个考官的期望值为0
            //memset(ex_examiner, 0, sizeof(int)); 
            SetIntArrayAllValue(ex_examiner, 0);
            // 每个任务的初始期望值是与她相连的考官最大的权重
            for (int i = 0; i < N; ++i)
            {
                ex_task[i] = match_weight[i][0];
                for (int j = 1; j < N; ++j)
                {
                    ex_task[i] = Math.Max(ex_task[i], match_weight[i][j]);
                }
            }

            // 尝试为每一个任务解决归宿问题
            for (int i = 0; i < N; ++i)
            {
                // 因为要取最小值 初始化为无穷大
                //fill(slack, slack + N, INF);
                SetIntArrayAllValue(slack, int.MaxValue);

                while (true)
                {
                    // 为每个任务解决归宿问题的方法是 ：如果找不到就降低期望值，直到找到为止

                    // 记录每轮匹配中考官任务是否被尝试匹配过
                    SetBoolArrayAllValue(vis_task, false);
                    SetBoolArrayAllValue(vis_examiner, false);
                    if (dfs(i))
                    {
                        break; // 找到归宿 退出
                    }

                    // 如果不能找到 就降低期望值
                    // 最小可降低的期望值
                    int d = INF;
                    for (int j = 0; j < N; ++j)
                    {
                        if (!vis_examiner[j])
                        {
                            d = Math.Min(d, slack[j]);
                        }
                    }

                    for (int j = 0; j < N; ++j)
                    {
                        // 所有访问过的任务降低期望值
                        if (vis_task[j])
                        {
                            ex_task[j] -= d;
                        }

                        // 所有访问过的考官增加期望值
                        if (vis_examiner[j])
                        {
                            ex_examiner[j] += d;
                        }
                        // 没有访问过的examiner 因为task们的期望值降低，距离得到任务倾心又进了一步！
                        else
                        {
                            slack[j] -= d;
                        }
                    }
                }
            }

            // 匹配完成 求出所有配对的权重的和
            int res = 0;
            for (int i = 0; i < N; ++i)
            {
                res += match_weight[match[i]][i];
            }

            return res;
        }

    

        private static void SetIntArrayAllValue(int[] intList, int value)
        {
            for (int i = 0; i < intList.Length; i++)
            {
                intList[i] = value;
            }
            return;
        }

        private static void SetBoolArrayAllValue(bool[] intList, bool value)
        {
            for (int i = 0; i < intList.Length; i++)
            {
                intList[i] = value;
            }
            return;
        }

        public static void GenerateMatchWeight(List<MatchTaskModel> taskModels, List<MatchExaminerModel> examinerModels)
        {
            for (int i = 0; i < taskModels.Count; i++)
            {
                for (int j = 0; j < examinerModels.Count; j++)
                {
                    match_weight[i][j] = -100;
                    if (Array.IndexOf(examinerModels[j].AvailableTaskTypes, taskModels[i].TaskType) >= 0)
                    {
                        match_weight[i][j] = taskModels[i].Weight;
                    }

                }
            }            
        }
        public static int[][] RectangularIntArray(int size1, int size2)
        {
            int[][] newArray = new int[size1][];
            for (int array1 = 0; array1 < size1; array1++)
            {
                newArray[array1] = new int[size2];
            }

            return newArray;
        }
    }
}