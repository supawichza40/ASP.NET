using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThingsILearned.Models;

namespace ThingsILearned.Controllers
{
    public class PostController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PostController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Post
        public ActionResult Index()
        {
            var allPosts = _context.Posts.ToList();
            if (allPosts==null)
            {
                Response.StatusCode = 404;

                return HttpNotFound();
            }
            return View(allPosts);
        }
        public ActionResult Detail(int id)
        {
            var getPostById = _context.Posts.FirstOrDefault(p => p.Id == id);
            if (getPostById == null)
            {
                return HttpNotFound();
            }
            return View(getPostById);
        }
        public ActionResult EditForm(int id)
        {
            var getPostById = _context.Posts.FirstOrDefault(p => p.Id == id);
            return View(getPostById);
        }
        public ActionResult Save(Post newPost,int id)
        {
            var getPostByIdFromDb = _context.Posts.FirstOrDefault(p=>p.Id==id);
            getPostByIdFromDb.Title = newPost.Title;
            getPostByIdFromDb.SubHeading = newPost.SubHeading;
            getPostByIdFromDb.Description = newPost.Description;
            getPostByIdFromDb.LastModified = DateTime.Now;
            getPostByIdFromDb.Author = newPost.Author;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult CreatePost(Post post)
        {
            post.CreatedDate = DateTime.Now;
            post.LastModified = DateTime.Now;
            _context.Posts.Add(post);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeletePost(int id)
        {
            var postByIdFromDb = _context.Posts.FirstOrDefault(p => p.Id == id);
            _context.Posts.Remove(postByIdFromDb);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}