using System;
using System.Collections.Generic;

namespace KM
{
    class Program
    {

        static void Main(string[] args)
        {
            // 初始化数据

            //love[i][j] = int.Parse(tempVar);
            var tasks = new List<MatchTaskModel>();
            var examiners = new List<MatchExaminerModel>();


            tasks.Add(new MatchTaskModel(TaskRoleTypeEnum.IOL, 31));
            tasks.Add(new MatchTaskModel(TaskRoleTypeEnum.VCS, 21));
            tasks.Add(new MatchTaskModel(TaskRoleTypeEnum.VCS, 22));
            tasks.Add(new MatchTaskModel(TaskRoleTypeEnum.IOL, 32));
            tasks.Add(new MatchTaskModel(TaskRoleTypeEnum.EOR, 13));
            tasks.Add(new MatchTaskModel(TaskRoleTypeEnum.EOR, 12));

            examiners.Add(new MatchExaminerModel("1", TaskRoleTypeEnum.IOL, TaskRoleTypeEnum.VCS));
            examiners.Add(new MatchExaminerModel("2", TaskRoleTypeEnum.IOL, TaskRoleTypeEnum.VCS, TaskRoleTypeEnum.EOR));
            examiners.Add(new MatchExaminerModel("3", TaskRoleTypeEnum.IOL));
            examiners.Add(new MatchExaminerModel("4", TaskRoleTypeEnum.VCS));
            examiners.Add(new MatchExaminerModel("5", TaskRoleTypeEnum.IOL));
            examiners.Add(new MatchExaminerModel("6", TaskRoleTypeEnum.VCS));

            KMHelper.GenerateMatchWeight(tasks, examiners);
            Console.Write("{0:D}\n", KMHelper.KM());
            var match = KMHelper.match;
            for (int i = 0; i < match.Length; i++)
            {
                if(Array.IndexOf(examiners[i].AvailableTaskTypes, tasks[match[i]].TaskType) < 0)
                {
                    match[i] = -1;
                }
            }
            Console.Read();
        }
    }




}

