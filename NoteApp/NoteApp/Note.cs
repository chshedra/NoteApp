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
        /// <summary>
        /// Название заметки
        /// </summary>
        private string _title;
        
        /// <summary>
        /// Содержимое заметки
        /// </summary>
        private string _text;

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
                if(value.Length > 50)
                {
                    throw new ArgumentException("Размер имени заметки должен быть " +
                        "менее 50 символов. " + "Текущий размер:" + value.Length);
                }
                Modified = DateTime.Now;
                _title = value;
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
                Modified = DateTime.Now;
            }
        }

        /// <summary>
        ///  Возвращает и задает текст заметки
        ///  Устанавливает время последнего изменения заметки
        /// </summary>
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
                Modified = DateTime.Now;
            }
        }

        /// <summary>
        ///  Возвращает время создания заметки
        /// </summary>
        public DateTime Created { get; private set; }

        /// <summary>
        ///  Возвращает время последнего изменения заметки
        /// </summary>
        public DateTime Modified { get; private set; }

        /// <summary>
        /// Метод, создающий копию объекта класса
        /// </summary>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        
        /// <summary>
        /// Конструктор для сериализации, устанавливает значения полей Название, Текст, 
        /// Категория заметки, Время создания, Время изменения
        /// </summary>
        [JsonConstructor]
        public Note(string title, string text, NoteCategory category, 
            DateTime created, DateTime modified) 
        {
            Title = title;
            Text = text;
            Category = category;
            Created = created;
            Modified = modified;
        }

        /// <summary>
        /// Конструктор без параметров, устанавливает значения полей Название, Текст заметки, 
        /// Категория, Время создания ,Время изменения
        /// </summary>
        public Note()
        {
            Title = "Без названия";
            Text = null;
            Category = NoteCategory.Other;
            Created = DateTime.Now;
        }
    }
}
