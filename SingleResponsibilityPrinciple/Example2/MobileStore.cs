using SingleResponsibilityPrinciple.Example2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Example2
{
    public class MobileStore
    {
        List<Phone> phones = new();

        public IPhoneReader Reader { get; set; }
        public IPhoneBinder Binder { get; set; }
        public IPhoneValidator Validator { get; set; }
        public IPhoneSaver Saver { get; set; }



        public MobileStore(IPhoneReader reader, IPhoneBinder binder, IPhoneValidator validator, IPhoneSaver saver)
        {
            this.Reader = reader;
            this.Binder = binder;
            this.Validator = validator;
            this.Saver = saver;
        }

        public void Process()
        {
            string?[] data = Reader.GetInputData();
            Phone phone = Binder.CreatePhone(data);
            if (Validator.IsValid(phone))
            {
                phones.Add(phone);
                Saver.Save(phone, "store.txt");
                Console.WriteLine("Данные успешно обработаны");
            }
            else
            {
                Console.WriteLine("Некорректные данные");
            }


            //Класс - бог инкапсулирует все

            //public void Process()
            //{
            //    Console.WriteLine("Enter model");

            //    string? model = Console.ReadLine();
            //    Console.WriteLine("Enter price");

            //    // валидация
            //    bool result = int.TryParse(Console.ReadLine(), out var price);

            //    if (result == false || price <= 0 || string.IsNullOrEmpty(model))
            //    {
            //        throw new Exception("Некорректно введены данные");
            //    }
            //    else
            //    {
            //        phones.Add(new Phone(model, price));
            //        // сохраняем данные в файл
            //        using (StreamWriter writer = new StreamWriter("store.txt", true))
            //        {
            //            writer.WriteLine(model);
            //            writer.WriteLine(price);
            //        }
            //        Console.WriteLine("Данные успешно обработаны");
            //    }
            //}
        }
    }
}