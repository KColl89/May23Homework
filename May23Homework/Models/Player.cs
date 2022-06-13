using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace May23Homework.Models
{
    public class Player
    {
		[Key]
		public int Id { get; set; }

		private string _name = "";
		private string _email = "";
		private int _playerLevel;
		public Guid gId { get; set; }

		public string Name { get => _name; set => _name = value; }

		public string Email { get => _email; set => ValidateEmail(value); }

		public int PlayerLevel
		{
			get => _playerLevel;
			set => _playerLevel = value;
		}
		/// <summary>
		/// Method that takes input and validates that it is indeed an email.
		/// </summary>
		/// <param name="input">String</param>
		/// <returns>Returns error message or input.</returns>
		public static string ValidateEmail(string input)

		{

			string error = "Enter a proper email address";
			Regex _validEmailPattern = new Regex(
			   @"^[a-zA-Z]\w*@(\w+\.)+\w+$",
			   RegexOptions.Compiled
			   );

			if (!_validEmailPattern.IsMatch(input))
			{
				do
				{
					Console.WriteLine(error);
					input = Console.ReadLine();
				} while (!_validEmailPattern.IsMatch(input));

			}

			return input;

		}

		public static List<Player> PLayerList(int size)
		{
			List<Player> list = new List<Player>();
			for (int i = 0; i < size; i++)
			{
				list.Add(new Player());
				Console.WriteLine("Enter player name:");
				list[i].Name = Console.ReadLine();
				Console.WriteLine("Enter player email:");
				list[i].Email = Console.ReadLine();
				Console.WriteLine("Enter player level:");
				list[i].PlayerLevel = Int32.Parse(Console.ReadLine());
			}
			return list;
		}
	}
}
