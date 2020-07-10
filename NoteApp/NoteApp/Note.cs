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
        //TODO: +поле не может что-либо устанавливать
        /// <summary>
        /// Название заметки
        /// </summary>
        
        private string _title;
        //TODO: +убрать слово note из названия поля
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
        //TODO: +лучше переименовать в Created
        //TODO: +сеттер должен быть закрытым
        /// <summary>
        ///  Возвращает время создания заметки
        /// </summary>
        public DateTime Created { get; private set; }
        //TODO: +лучше переименовать в Modified
        //TODO: +почему не сериализуется? А не это имел ввиду, когда говорил, что надо решить проблему с сериализацией времени
        //TODO: +сеттер должен быть закрытым
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
        //TODO: зачем два конструктора?
        // Теперь один для сериализации, другой для обычного создания объекта
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
