using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{
	public class IdentifiableObject
	{
		//feilds
		private List<string> _identifiers;

		//constuctions
		public IdentifiableObject(string[] idents)
		{
			_identifiers = new List<string>();
			foreach (string ident in idents)
			{
				_identifiers.Add(ident.ToLower());
			}
		}

		//getter
		public string FirstId
		{
			get
			{
				if(_identifiers.Count == 0)
				{
					return "";
				}
				else
				{
					return _identifiers.First();
				}
			}
		}

		//method
		public bool AreYou(string id)
		{
			return _identifiers.Contains(id.ToLower());
		}

		public void AddIdentifier(string identifier)
		{
			_identifiers.Add(identifier.ToLower());
		}
	}
}
