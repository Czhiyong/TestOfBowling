﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestOfBowling
{
    
    /// <summary>
    /// GameTest 的摘要说明
    /// </summary>
    [TestClass]
    public class GameTest
    {

        private Game game;

        
        public void SteUp()
        {
            game = new Game();
        }

        #region 附加测试特性
        //
        // 编写测试时，可以使用以下附加特性:
        //
        // 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在运行每个测试之前，使用 TestInitialize 来运行代码
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestOneThrow()
        {
            SteUp();
     //      Game game = new Game();
            game.Add(5);
            Assert.AreEqual(5, game.Score);
        }
         [TestMethod]
        public void TestTwoThrowNoMark()
        {
    //        Game game = new Game ();
            SteUp();
            game.Add(5);
            game.Add(4);
            Assert.AreEqual(9, game.Score);
        }
         [TestMethod]
        public void TestFourThrowsNoMark()
        {
     //       Game game = new Game();
            SteUp();
            game.Add(5);
            game.Add(4);
            game.Add(7);
            game.Add(2);
            Assert.AreEqual(18, game.Score);
            Assert.AreEqual(9, game.ScoreForFrame(1));
            Assert.AreEqual(18, game.ScoreForFrame(2));
        }
         [TestMethod]
        public void TestSimpleSpare()
        {
      //      Game game = new Game();
            SteUp();
            game.Add(3);
            game.Add(7);
            game.Add(3);
            Assert.AreEqual(13, game.ScoreForFrame(1));
        }
    }
}
