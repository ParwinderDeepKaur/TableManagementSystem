using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableManagementLibrary.Models
{
   public class bookingTable
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// FirstName
        /// </summary>
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        /// <summary>
        /// LastName
        /// </summary>
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        /// <summary>
        /// PhoneNumber
        /// </summary>
        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// MealId
        /// </summary>
        [ForeignKey("MealId")]
        [Display(Name = "Meal")]
        public int MealId { get; set; }

        /// <summary>
        /// Meals
        /// </summary>
        public meal Meals { get; set; }


        /// <summary>
        /// TableId
        /// </summary>
        [ForeignKey("TableId")]
        [Display(Name = "Tables")]
        public int TableId { get; set; }

        /// <summary>
        /// Tables
        /// </summary>
        public tables Tables { get; set; }

        /// <summary>
        /// FoodId
        /// </summary>
        [ForeignKey("FoodId")]
        [Display(Name = "Food Type")]
        public int FoodId { get; set; }

        /// <summary>
        /// FoodTypes
        /// </summary>
        public foodType FoodTypes { get; set; }

        /// <summary>
        /// FlowerId
        /// </summary>
        [ForeignKey("FlowerId")]
        [Display(Name = "Flowers")]
        public int FlowerId { get; set; }

        /// <summary>
        /// Flowers
        /// </summary>
        public flowers Flowers { get; set; }

        /// <summary>
        /// TablePositionId
        /// </summary>
        [ForeignKey("TablePositionId")]
        [Display(Name = "Table Position")]
        public int TablePositionId { get; set; }

        /// <summary>
        /// TablePositions
        /// </summary>
        public tablePosition TablePositions { get; set; }
        

         /// <summary>
        /// SpecialNotes
        /// </summary>
        [Required]
        [Display(Name = "Special Notes")]
        public string SpecialNotes { get; set; }




    }
}
