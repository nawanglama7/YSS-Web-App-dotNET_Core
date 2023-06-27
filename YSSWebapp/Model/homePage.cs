using Microsoft.Identity.Client;
using Microsoft.VisualBasic;
using System.Reflection.Metadata;

namespace YSSWebapp.Model
{
    public class homePage
    {
        [Key]
        public int Id{ get; set; }
        [Required(ErrorMessage ="About field is required with minimum 100 character and max 1000 character.")]
        [StringLength(maximumLength:1000, MinimumLength =100)]
        public string About { get; set; }
        //public string News { get; set; }
        
    }
    public class news
    {
        [Key]
        public int Id { get; set; }
        public DateTime Newsdate { get; set; }
        public byte[] NewsImg { get; set; }
        public string NewsContent { get; set; }
    }
    public class members
    {
        [Key]             
        public string StateID { get; set; }
        public string BAIID { get; set; }
        public int MemberType { get; set; }
        public byte[] pic{ get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public DateTime DoB { get; set; }
        public string PhoneNo { get; set; }

    }
}
