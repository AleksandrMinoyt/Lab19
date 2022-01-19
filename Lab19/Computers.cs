using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19
{
    class Computers
    {
        private int _code;                       // код
        private string _name;                    // название
        private string _manufacturer;            // марка
        private string _processorType;           // тип процессора
        private double _processorFrequency;      // частота процессора
        private int _ram;                        // оперативная память
        private int _hddVolume;               // объём жесткого диска
        private int _videoRamVolume;             // объём виопамяти
        private double _cost;                    // стоимость
        private int _count;                      // количество

        public Computers(int Code,
                         string Name,
                         string Manufacturer,
                         string ProcessorType,
                         double ProcessorFrequency,
                         int Ram,
                         int HhddVolume,
                         int VideoRamVolume,
                         double Cost,
                         int Count)
        {
            _code = Code;
            _name = Name;
            _manufacturer = Manufacturer;
            _processorType = ProcessorType;
            _processorFrequency = ProcessorFrequency;
            _ram = Ram;
            _hddVolume = HhddVolume;
            _videoRamVolume = VideoRamVolume;
            _cost = Cost;
            _count = Count;
        }

        public int Code
        {
            get
            {
                return _code;
            }

            set
            {
                _code = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return _manufacturer;
            }

            set
            {
                _manufacturer = value;
            }
        }

        public string ProcessorType
        {
            get
            {
                return _processorType;
            }

            set
            {
                _processorType = value;
            }
        }

        public double ProcessorFrequency
        {
            get
            {
                return _processorFrequency;
            }

            set
            {
                _processorFrequency = value;
            }
        }

        public int Ram
        {
            get
            {
                return _ram;
            }

            set
            {
                _ram = value;
            }
        }

        public int HddVolume
        {
            get
            {
                return _hddVolume;
            }

            set
            {
                _hddVolume = value;
            }
        }

        public int VideoRamVolume
        {
            get
            {
                return _videoRamVolume;
            }

            set
            {
                _videoRamVolume = value;
            }
        }

        public double Cost
        {
            get
            {
                return _cost;
            }

            set
            {
                _cost = value;
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }

            set
            {
                _count = value;
            }
        }
    }
}
