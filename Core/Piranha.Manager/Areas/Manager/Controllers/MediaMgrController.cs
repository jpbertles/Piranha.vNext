/*
 * Piranha CMS
 * Copyright (c) 2014, Håkan Edling, All rights reserved.
 * 
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 3.0 of the License, or (at your option) any later version.
 * 
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
 * Lesser General Public License for more details.
 * 
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library.
 */

using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Piranha.Manager.Models.Alias;

namespace Piranha.Areas.Manager.Controllers
{
	/// <summary>
	/// Controller for managing aliases.
	/// </summary>
	[Authorize]
	[RouteArea("Manager", AreaPrefix = "manager")]
    public class MediaMgrController : ManagerController
    {
		/// <summary>
		/// Gets a list of the currently available media.
		/// </summary>
		/// <returns>The media list</returns>
		[Route("media")]
		public ActionResult List() {
			return View();
		}

		/// <summary>
		/// Gets the media.
		/// </summary>
		/// <returns>The media</returns>
		[Route("media/get")]
		public ActionResult Get() {
			return JsonData(true, Mapper.Map<IEnumerable<Piranha.Models.Alias>, IEnumerable<ListItem>>(api.Aliases.Get()));
		}

		/// <summary>
		/// Gets the media with the given id.
		/// </summary>
		/// <param name="id">The unique id</param>
		/// <returns>The media</returns>
		[Route("media/get/{id:Guid}")]
		public ActionResult GetSingle(Guid id) {
			return JsonData(true, EditModel.GetById(api, id));
		}

		/// <summary>
		/// Saves the given post model.
		/// </summary>
		/// <param name="model">The model</param>
		/// <returns>The redirect result</returns>
		[HttpPost]
		[Route("media/save")]
		[ValidateInput(false)]
		public ActionResult Save(EditModel model) {
			if (ModelState.IsValid) {
				model.Save(api);
				var items = Mapper.Map<IEnumerable<Piranha.Models.Alias>, IEnumerable<ListItem>>(api.Aliases.Get());
				var current = items.Where(c => c.Id == model.Id).SingleOrDefault();
				if (current != null) {
					current.Saved = true;
				}
				return JsonData(true, items);
			}
			return JsonData(false);
		}

		/// <summary>
		/// Deletes the alias with the given id.
		/// </summary>
		/// <param name="id">The unique id</param>
		/// <returns>The redirect result</returns>
		[Route("media/delete/{id:Guid}")]
		public ActionResult Delete(Guid id) {
			var alias = api.Aliases.GetSingle(id);
			if (alias != null) {
				api.Aliases.Remove(alias);
				api.SaveChanges();
				return JsonData(true, Mapper.Map<IEnumerable<Piranha.Models.Alias>, IEnumerable<ListItem>>(api.Aliases.Get()));
			}
			return JsonData(false);
		}
    }
}