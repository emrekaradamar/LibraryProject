using Microsoft.AspNetCore.Identity;

namespace LibraryProject.BLL.Entities
{
    public class Role : IdentityRole<int>
    {
        public Role()
        { }
        public Role(string name) : base(name) { }
    }
}
