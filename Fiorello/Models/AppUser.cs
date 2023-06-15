using System;
using Microsoft.AspNetCore.Identity;

namespace Fiorello.Models
{
	public class AppUser : IdentityUser 
	{
		public string FullName { get; set; }
	}
}

