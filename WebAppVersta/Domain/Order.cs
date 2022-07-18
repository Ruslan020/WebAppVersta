using System;
using System.ComponentModel.DataAnnotations;

namespace WebAppVersta.Domain
{
    public class Order
    {
        [Required]
        public Guid id { get; set; }

        [Display (Name="Город отправителя")]
        public string senderTown { get; set; }

        [Display(Name = "Адрес отправителя")]
        public string senderAddress { get; set; }

        [Display(Name = "Город получателя")]
        public string recieverTown { get; set; }

        [Display(Name = "Адрес получателя")]
        public string recieverAddress { get; set; }

        [Display(Name = "Вес груза")]
        public string weight { get; set; }

        [Display(Name = "Дата забора груза")]
        public DateTime date { get; set; }
    }
}
