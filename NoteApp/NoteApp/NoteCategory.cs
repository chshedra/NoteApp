using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Перечисление <see cref="NoteCategory"/>, хранящее информацию о категориях заметок
    /// </summary>
    public enum NoteCategory
    {
        /// <summary>
        /// Документы
        /// </summary>
        Documents,

        /// <summary>
        /// Финансы
        /// </summary>
        Finance,

        /// <summary>
        /// Дом
        /// </summary>
        Home,

        /// <summary>
        /// Люди
        /// </summary>
        People,

        /// <summary>
        /// Спорт и здоровье
        /// </summary>
        SportAndHealth,

        /// <summary>
        /// Работа
        /// </summary>
        Work,

        /// <summary>
        /// Разное
        /// </summary>
        Other
    }
}
