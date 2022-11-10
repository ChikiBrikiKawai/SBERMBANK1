using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1

{
    public class Delegate3
    {
        public class Acc
        {
            public delegate void AccountHandler(string message);
            AccountHandler taken;
            public event AccountHandler Notify;

            public int Sum { get; private set; }
            string Name;

            public Acc(int Sum, string Name)
            {
                this.Sum = Sum;
                this.Name = Name;
            }
            public void RegisterHandler(AccountHandler del)
            {
                taken = del;
            }
            public void Info(int sum, string name)
            {
                Notify?.Invoke($"ФИО Пользователя: {name}, баланс: {sum}");
                taken?.Invoke($"ФИО Пользователя: {name}, баланс: {sum}");
            }
            public void Add(int sum)
            {
                Sum += +sum;
                Notify?.Invoke($"на счёт поступило {sum}, баланс {Sum}");
                taken?.Invoke($"на счёт поступило {sum}, баланс {Sum}");
            }
            public void Take(int sum)
            {
                if (this.Sum >= Sum)
                {
                    this.Sum -= sum;
                    Notify?.Invoke($"со счёта списано {sum}, баланс {Sum}");
                    taken?.Invoke($"со счёта списано {sum}, баланс {Sum}");
                }
                else
                {
                    Notify?.Invoke($"Недостаточно средств. Текущий баланс:{this.Sum}");
                    taken?.Invoke($"Недостаточно средств. Текущий баланс:{this.Sum}");
                }
            }

        }
    }

}