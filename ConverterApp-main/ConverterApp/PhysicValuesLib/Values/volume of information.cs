using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicValuesLib.Values
{
    public class volume_of_information : IValue
    {
        private double Value { get; set; }
        private string? From { get; set; }
        private string? To { get; set; }

        private string _valueName = "Объем информации";

        private List<string> _measureList = new List<string>()
    {
        "байт",
        "килобайт",
        "мегабайт",
        "гигабайт",
        "терабайт",
        "петабайт"
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
                case "байт":
                    break;
                case "килобайт":
                    Value /= 1000;
                    break;
                case "мегабайт":
                    Value /= 1000000;
                    break;
                case "гигабайт":
                    Value /= 1000000000;
                    break;
                case "терабайт":
                    Value /= 1000000000000;
                    break;
                case "петабайт":
                    Value /= 1000000000000000;
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
                case "байт":
                    break;
                case "килобайт":
                    Value *= 1000;
                    break;
                case "мегабайт":
                    Value *= 1000000;
                    break;
                case "гигабайт":
                    Value *= 1000000000;
                    break;
                case "терабайт":
                    Value *= 1000000000000;
                    break;
                case "петабайт":
                    Value *= 1000000000000000;
                    break;
            }
        }

        public string GetValueName()
        {
            return _valueName;
        }
    }
}

