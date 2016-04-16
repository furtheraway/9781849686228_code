using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using CH07.BlogReader.ViewModels;
using CH07.CookbookMVVM.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CH07.BlogReader.Models;

namespace CH07.BlogReaderTest {
	/// <summary>
	/// Summary description for UnitTest1
	/// </summary>
	[TestClass]
	public class UnitTest1 {
		Blog _blog;

		public UnitTest1() {
			_blog = new Blog {
				Blogger = new Blogger {
					Name = "Homer Simpson",
					Email = "homer@springfield.com",
				},
				BlogTitle = "Homer vs. World",
				Posts = {
					new BlogPost {
						When = new DateTime(2010, 7, 16),
						Title = "This is my first",
						Text = "I hate Springfield",
						Comments = {
							new BlogComment {
								Name = "Mr. Bernz",
								Text = "You're fired!",
								When = new DateTime(2010, 7, 20)
							}
						}
					},
					new BlogPost {
						When = new DateTime(2012, 3, 7),
						Title = "Second post",
						Text = "Working is hard",
						Comments = {
							new BlogComment {
								Name = "Lisa S.",
								Text = "Come on dad!",
								When = new DateTime(2012, 3, 10)
							},
							new BlogComment {
								Name = "Marge S.",
								Text = "Homy! stop writing things!",
								When = new DateTime(2012, 3, 9)
							}
						}
					}

				}
			};
		}


		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext {
			get {
				return testContextInstance;
			}
			set {
				testContextInstance = value;
			}
		}

		#region Additional test attributes
		//
		// You can use the following additional attributes as you write your tests:
		//
		// Use ClassInitialize to run code before running the first test in the class
		// [ClassInitialize()]
		// public static void MyClassInitialize(TestContext testContext) { }
		//
		// Use ClassCleanup to run code after all tests in a class have run
		// [ClassCleanup()]
		// public static void MyClassCleanup() { }
		//
		// Use TestInitialize to run code before running each test 
		// [TestInitialize()]
		// public void MyTestInitialize() { }
		//
		// Use TestCleanup to run code after each test has run
		// [TestCleanup()]
		// public void MyTestCleanup() { }
		//
		#endregion

		[TestMethod]
		public void TestAddPost() {
			var post = new BlogPost {
				Title = "Some title",
				Text = "Some text"
			};
			var vm = new BlogVM {
				Model = _blog, 
				NewPostDialogService = new AutoDialogService {
					ViewModel = post
				}
			};
			vm.NewPostCommand.Execute(post);
			Assert.IsTrue(_blog.Posts.Count == 3);
		}
	}
}
