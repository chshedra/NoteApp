using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс, хранящий информацию о названии, тексте, категории, 
    /// времени создания и времени последнего изменения заметки
    /// </summary>
    public class Note : ICloneable
    {
        /// <summary>
        /// Название заметки
        /// Устанавливает время последнего изменения заметки
        /// </summary>
        private string _title;

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
        /// Время последнего изменения заметки
        /// </summary>
        private DateTime _lastChangeTime;

        /// <summary>
        /// Время создания заметки
        /// </summary>
        private DateTime _creationTime;

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
                    _title = value;
                    _lastChangeTime = DateTime.Now;
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
                _lastChangeTime = DateTime.Now;
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
                _lastChangeTime = DateTime.Now;
            }
        }

        /// <summary>
        ///  Возвращает время создания заметки
        /// </summary>
        public DateTime CreationTime
        {
            get { return _creationTime; }
 
            private set
            {
                _creationTime = DateTime.Now;

            }
        }

        /// <summary>
        ///  Возвращает время последнего изменения заметки
        /// </summary>
        public DateTime LastChangeTime { get; private set; }

        /// <summary>
        /// Метод, создающий копию объекта класса
        /// </summary>
        public object Clone()
        {
            return this.MemberwiseClone();
        }

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
            LastChangeTime = DateTime.Now;
        }
    }
}
