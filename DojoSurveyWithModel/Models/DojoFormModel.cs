namespace DojoSurveyWithModel;
using System.ComponentModel.DataAnnotations;

public class DojoFormClass
{
    // <=== Fields/Validation ===>
    // <== Validation ==>
    [Required(ErrorMessage ="Name is required")]
    [MinLength(3,ErrorMessage ="Name must be at least 3 characters")]
    // <== Field ==>
    public string? name {get;set;}
    
    // <=== Validation ===>
    [Required(ErrorMessage ="dojoLocation is required")]
    [MinLength(3,ErrorMessage ="dojoLocation must be at least 3 characters")]
    // <== Field ==>
    public string? dojoLocation {get;set;}

    // <== Validation ==>
    [Required(ErrorMessage ="FavoriteLanguage is required")]
    [MinLength(1,ErrorMessage ="FavoriteLanguage must be at least 1 characters")]
    [MaxLength(6,ErrorMessage ="FavoriteLanguage must not exceed 6  characters")]
    // <== Field ==>
    public string? favoriteLanguage {get;set;}

    // <=== FavoriteLanguage Validation ===>
    [MaxLength(20, ErrorMessage ="Comment Must not exceed 20 characters")]
    // <=== FavoriteLanguage Field ===>
    public string? comment {get;set;}
} 