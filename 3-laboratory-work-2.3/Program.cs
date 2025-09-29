using System;

namespace lab02_03
{
    class DocumentWorker
    {
        public virtual void OpenDocument() => Console.WriteLine("Документ открыт");
        public virtual void EditDocument() => Console.WriteLine("Редактирование документа доступно в версии Pro");
        public virtual void SaveDocument() => Console.WriteLine("Сохранение документа доступно только в версии Pro");
    }
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument() => Console.WriteLine("Документ отредактирован");
        public override void SaveDocument() => Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
    }
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument() => Console.WriteLine("Документ сохранен в новом формате");
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ключ доступа (при отсутствии ключа нажмите Enter): ");
            string key = Console.ReadLine();
            DocumentWorker worker;

            switch (key)
            {
                case "proKEY123":
                    worker = new ProDocumentWorker();
                    break;
                case "expertKEY993":
                    worker = new ExpertDocumentWorker();
                    break;
                default:
                    worker = new DocumentWorker();
                    break;
            }

            worker.OpenDocument();
            worker.EditDocument();
            worker.SaveDocument();
        }
    }
}