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
        //TODO: писать каждый раз "Категория заметок" не нужно. В контексте вызова значения перечисления и так будет понятно, что это относится к категориям заметки
        /// <summary>
        /// Категория заметок "Документы"
        /// </summary>
        Documents,

        /// <summary>
        /// Категория заметок "Финансы"
        /// </summary>
        Finance,

        /// <summary>
        /// Категория заметок "Дом"
        /// </summary>
        Home,

        /// <summary>
        /// Категория заметок "Люди"
        /// </summary>
        People,

        /// <summary>
        /// Категория заметок "Спорт и здоровье"
        /// </summary>
        SportAndHealth,

        /// <summary>
        /// Категория заметок "Работа"
        /// </summary>
        Work,

        /// <summary>
        /// Категория заметок "Разное"
        /// </summary>
        Other
    }
}
