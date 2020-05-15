using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreAlbums.Models;
using AspNetCoreAlbums.Services;
using Microsoft.AspNetCore.Mvc;
namespace AspNetCoreAlbums.Controllers
{
    public class AlbumsController : Controller
    {
        private readonly IAlbumsItemService _AlbumsItemService;

        public AlbumsController(IAlbumsItemService AlbumsItemService)
        {
            _AlbumsItemService = AlbumsItemService;
        }

        public async Task<IActionResult> Index()
        {
            var items = await _AlbumsItemService.GetIncompleteItemsAsync();
            // Get to-do items from database
            // Put items into a model
            // Pass the view to a model and render
            var model = new AlbumsViewModel()
            {
                Items = items
            };
            return View(model);
        } //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> AddItem(AlbumsItem newItem)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    var successful = await _AlbumsItemService.AddItemAsync(newItem);
        //    if (!successful)
        //    {
        //        return BadRequest("Could not add item.");
        //    }
        //    return RedirectToAction("Index");
        //}


    }

}