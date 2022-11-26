using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicValuesLib.Values
{
    public class Chastota : IValue
    {
        private double Value { get; set; }
        private string? From { get; set; }
        private string? To { get; set; }

        private string _valueName = "Частота";

        private List<string> _measureList = new List<string>()
    {
        "Герц",
        "Килогерц",
        "Мегагерц",
        "Гигагерц"
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
                case "Герц":
                    break;
                case "Килогерц":
                    Value /= 1000;
                    break;
                case "Мегагерц":
                    Value /= 1000000;
                    break;
                case "Гигагерц":
                    Value /= 1000000000;
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
                case "Герц":
                    break;
                case "Килогерц":
                    Value *= 1000;
                    break;
                case "Мегагерц":
                    Value *= 1000000;
                    break;
                case "Гигагерц":
                    Value *= 1000000000;
                    break;
            }
        }

        public string GetValueName()
        {
            return _valueName;
        }
    }
}

