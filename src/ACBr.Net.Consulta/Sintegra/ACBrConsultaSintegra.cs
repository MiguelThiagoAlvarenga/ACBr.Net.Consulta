// ***********************************************************************
// Assembly         : ACBr.Net.Consulta
// Author           : RFTD
// Created          : 02-20-2017
//
// Last Modified By : RFTD
// Last Modified On : 02-20-2017
// ***********************************************************************
// <copyright file="ACBrConsultaSintegra.cs" company="ACBr.Net">
//		        		   The MIT License (MIT)
//	     		    Copyright (c) 2014 - 2017 Grupo ACBr.Net
//
//	 Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//	 The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//	 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Drawing;
using ACBr.Net.Core;
using ACBr.Net.Core.Exceptions;
using ACBr.Net.Core.Extensions;

namespace ACBr.Net.Consulta.Sintegra
{
	/// <summary>
	/// Class ACBrConsultaSintegra. This class cannot be inherited.
	/// </summary>
	/// <seealso cref="ACBrConsultaBase" />
	[ToolboxBitmap(typeof(ACBrConsultaSintegra), "ACBr.Net.Consulta.ACBrConsultaSintegra.bmp")]
	public sealed class ACBrConsultaSintegra : ACBrConsultaBase
	{
		#region Fields

		private ConsultaSintegraBase consultaSintegra;

		#endregion Fields

		#region Events

		public event EventHandler<CaptchaEventArgs> OnGetCaptcha;

		#endregion Events

		#region Methods

		/// <summary>
		/// Gets the captcha.
		/// </summary>
		/// <returns>Image.</returns>
		public Image GetCaptcha()
		{
			Guard.Against<ACBrException>(consultaSintegra.IsNull(), "Selecione um estado primeiro");

			return consultaSintegra.GetCaptcha();
		}

		/// <summary>
		/// Consultas the specified CNPJ.
		/// </summary>
		/// <param name="cnpj">The CNPJ.</param>
		/// <param name="ie">The ie.</param>
		/// <param name="captcha">The captcha.</param>
		/// <returns>ACBrEmpresa.</returns>
		public ACBrEmpresa Consulta(string cnpj, string ie = "", string captcha = "")
		{
			Guard.Against<ACBrException>(consultaSintegra.IsNull(), "Selecione um estado primeiro");

			return consultaSintegra.Consulta(cnpj, ie, captcha);
		}

		#endregion Methods
	}
}