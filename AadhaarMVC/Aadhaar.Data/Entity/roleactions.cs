﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using Iesi.Collections;
////using Iesi.Collections.Generic;
using Aadhaar.Data.Entity.Components;


using Aadhaar.Data.Entity;

namespace Aadhaar.Data.Entity 
{    
	/// <summary>
	/// An object representation of the roleactions table
	/// </summary>
	[Serializable]
	public class roleactions
	{
		protected System.Int32 _Id;

		private Roles _Role;
		private Users _User;
		private actions _Action;
		private System.Int32 _PermissionType;

		public virtual System.Int32 Id
		{
			get
			{
				return _Id;
			}
			set
			{
				_Id = value;
			}
		}

		public virtual Roles Role
		{
			get
			{
				return _Role;
			}
			set
			{
				_Role = value;
			}
		}
		public virtual Users User
		{
			get
			{
				return _User;
			}
			set
			{
				_User = value;
			}
		}
		public virtual actions Action
		{
			get
			{
				return _Action;
			}
			set
			{
				_Action = value;
			}
		}
		public virtual System.Int32 PermissionType
		{
			get
			{
				return _PermissionType;
			}
			set
			{
				_PermissionType = value;
			}
		}


	}
}
