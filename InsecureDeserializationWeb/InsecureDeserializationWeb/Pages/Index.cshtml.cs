using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.IO;

public class IndexModel : PageModel
{
    public UserDetails User { get; set; }

    public void OnGet()
    {
        string json = System.IO.File.ReadAllText("objeto.json");
        User = JsonConvert.DeserializeObject<UserDetails>(json);
    }
}

public class UserDetails
{
    public string Name { get; set; }
    public string Bio { get; set; }
}
