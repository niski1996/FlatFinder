﻿using Core.Common.Contracts;
using Core.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FlatFinder.Business.Entities
{
	[DataContract]
	public class Domain : EntityBase, IIdentifiableEntity
	{
		[DataMember]
		public string Name { get; set; }
		[DataMember]
		public int Id { get; set; }
		public int EntityId
		{
			get { return Id; }
			set { Id = value; }


		}
	}
}
