using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace GoHorseClassLibrary {
	public class Telefone {

		private int id;
		private Pessoa pessoa;
		private string numero = "";
		private string descricao = "";

		public Telefone(){

		}

		public int Id{
			get{
				return id;
			}
			set{
				id = value;
			}
		}

		public Pessoa Pessoa{
			get{
				return pessoa;
			}
			set{
				pessoa = value;
			}
		}

		public string Numero{
			get{
				return numero;
			}
			set{
				numero = value;
			}
		}

		public string Descricao{
			get{
				return descricao;
			}
			set{
				descricao = value;
			}
		}

	}

}//end namespace GoHorseClassLibrary