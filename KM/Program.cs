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
            var tasks = new List<TaskModel>();
            var examiners = new List<ExaminerModel>();

            tasks.Add(new TaskModel(TaskTypeEnum.IOL, 31));
            tasks.Add(new TaskModel(TaskTypeEnum.VCS, 21));
            //tasks.Add(new TaskModel(TaskTypeEnum.VCS, 22));
            //tasks.Add(new TaskModel(TaskTypeEnum.IOL, 32));
            //tasks.Add(new TaskModel(TaskTypeEnum.EOR, 11));
            //tasks.Add(new TaskModel(TaskTypeEnum.EOR, 12));

            //examiners.Add(new ExaminerModel("1", TaskTypeEnum.IOL, TaskTypeEnum.VCS));
            //examiners.Add(new ExaminerModel("2", TaskTypeEnum.IOL, TaskTypeEnum.VCS, TaskTypeEnum.EOR));
            //examiners.Add(new ExaminerModel("3", TaskTypeEnum.IOL));
            //examiners.Add(new ExaminerModel("4", TaskTypeEnum.VCS));
            examiners.Add(new ExaminerModel("5", TaskTypeEnum.IOL));
            examiners.Add(new ExaminerModel("6", TaskTypeEnum.EOR));

            KMHelper.GenerateMatchWeight(tasks, examiners);
            Console.Write("{0:D}\n", KMHelper.KM());
            var a = KMHelper.match;
            Console.Read();
        }
    }




}

