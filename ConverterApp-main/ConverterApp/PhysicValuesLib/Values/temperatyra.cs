using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicValuesLib.Values
{
    public class temperatyra : IValue
    {
        private double Value { get; set; }
        private string? From { get; set; }
        private string? To { get; set; }

        private string _valueName = "Температура";

        private List<string> _measureList = new List<string>()
    {
        "Градус Цельсия",
        "Градус Фаренгейта",
        "Кельвин",
    };

        public double GetConvertedValue(double value, string from, string to)
        {
            Value = value;
            From = from;
            To = to;

            ToSi();
            ToRequired();
            return Value;
        }

        /// <summary>
        /// Метод возвращает список единиц измерения
        /// </summary>
        /// <returns></returns>
        public List<string> GetMeasureList()
        {
            return _measureList;
        }

        /// <summary>
        /// Метод конвертирует в нужные единицы измерения
        /// </summary>
        public void ToRequired()
        {
            switch (To)
            {
                case "Градус Цельсия":
                    break;
                case "Градус Фаренгейта":
                    Value *= 9; Value /= 5; Value += 32;
                    break;
                case "Кельвин":
                    Value += 273.15;
                    break;
            }
        }

        /// <summary>
        /// Метод переводит в систему СИ
        /// </summary>
        public void ToSi()
        {
            switch (From)
            {
                case "Градус Цельсия":
                    break;
                case "Градус Фаренгейта":
                    Value -= 32; Value *= 5; Value /= 9;
                    break;
                case "Кельвин":
                    Value -= 273.15;
                    break;
            }
        }

        public string GetValueName()
        {
            return _valueName;
        }
    }
}

