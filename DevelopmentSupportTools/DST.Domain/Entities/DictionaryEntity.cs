using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DST.Domain.Entities
{
    /// <summary>
    /// 辞書エンティティクラス。
    /// </summary>
    [Table("Dictionaries")]
    public class DictionaryEntity
    {
        /// <summary>辞書IDを取得または設定します。</summary>
        [Display(Name = "辞書ID")]
        [Key]
        public int Id { get; set; }

        /// <summary>日本語を取得または設定します。</summary>
        [Display(Name = "日本語")]
        [Required(ErrorMessage = "{0}を入力してください。")]
        [StringLength(30, ErrorMessage = "{0}は{1}文字以内で入力してください。")]
        public string Japanese { get; set; }

        /// <summary>英語を取得または設定します。</summary>
        [Display(Name = "英語")]
        [Required(ErrorMessage = "{0}を入力してください。")]
        [StringLength(50, ErrorMessage = "{0}は{1}文字以内で入力してください。")]
        public string ShortWord { get; set; }

        /// <summary>備考を取得または設定します。</summary>
        [Display(Name = "備考")]
        [StringLength(300, ErrorMessage = "{0}は{1}文字以内で入力してください。")]
        public string Remarks { get; set; }
    }
}