﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Waher.Content.Asn1.Model.Values
{
	/// <summary>
	/// Represents a named value.
	/// </summary>
	public class Asn1NamedValue : Asn1ValueReference
	{
		private readonly Asn1Value value;

		/// <summary>
		/// Represents a named value.
		/// </summary>
		/// <param name="Identifier">Identifier</param>
		/// <param name="Value">Optional Value</param>
		public Asn1NamedValue(string Identifier, Asn1Value Value)
			: base(Identifier)
		{
			this.value = Value;
		}

		/// <summary>
		/// Optional Value
		/// </summary>
		public Asn1Value Value => this.value;
	}
}