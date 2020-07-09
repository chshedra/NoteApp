using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Класс <see cref="Note"/>, хранящий информацию о названии, тексте, категории, 
    /// времени создания и времени последнего изменения заметки
    /// </summary>
    public class Note : ICloneable
    {
        //TODO: поле не может что-либо устанавливать
        /// <summary>
        /// Название заметки
        /// Устанавливает время последнего изменения заметки
        /// </summary>
        private string _title;
        //TODO: убрать слово note из названия поля
        /// <summary>
        /// Содержимое заметки
        /// Устанавливает время последнего изменения заметки
        /// </summary>
        private string _noteText;

        /// <summary>
        /// Категория заметки
        /// </summary>
        private NoteCategory _category;


        /// <summary>
        /// Возвращает и задает название заметки. Размер названия не более 50 символов
        /// </summary>
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Размер имени заметки должен быть менее 50 символов. " +
                        "Текущий размер:" + value);
                }
                else
                {
                    LastChangeTime = DateTime.Now;
                    _title = value;
                }

            }
        }

        /// <summary>
        ///  Возвращает и задает категорию заметки
        /// </summary>
        public NoteCategory Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
                LastChangeTime = DateTime.Now;
            }
        }

        /// <summary>
        ///  Возвращает и задает текст заметки
        ///  Устанавливает время последнего изменения заметки
        /// </summary>
        public string NoteText
        {
            get
            {
                return _noteText;
            }
            set
            {
                _noteText = value;
                LastChangeTime = DateTime.Now;
            }
        }
        //TODO: лучше переименовать в Created
        //TODO: сеттер должен быть закрытым
        /// <summary>
        ///  Возвращает время создания заметки
        /// </summary>
        public DateTime CreationTime { get; set; }
        //TODO: лучше переименовать в Modified
        //TODO: почему не сериализуется? А не это имел ввиду, когда говорил, что надо решить проблему с сериализацией времени
        //TODO: сеттер должен быть закрытым
        /// <summary>
        ///  Возвращает время последнего изменения заметки
        /// </summary>
        [field: NonSerialized]
        public DateTime LastChangeTime { get; set; }

        /// <summary>
        /// Метод, создающий копию объекта класса
        /// </summary>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        //TODO: зачем два конструктора?
        /// <summary>
        /// Конструктор без параметров, устанавливает значения полей Название, Текст заметки и категория заметки  
        /// </summary>
        public Note() : this("Без названия", " ", NoteCategory.Other) { }

        /// <summary>
        /// Конструктор с параметрами, устанавливает значения полей Название, Текст заметки и категория заметки  
        /// </summary>
        public Note(string title, string noteText, NoteCategory category)
        {
            Title = title;
            NoteText = NoteText;
            Category = category;
            CreationTime = DateTime.Now;
        }
    }
}
