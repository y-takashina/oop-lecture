using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OopLecture
{
    public partial class Form1 : Form
    {
        private Bitmap _bmp;
        private Graphics _graphics;
        private Scene _scene;

        enum Scene
        {
            GameMain,
            Title
        }

        public Form1()
        {
            InitializeComponent();
            _bmp = new Bitmap(1280, 720);
            _graphics = Graphics.FromImage(_bmp);
            timer1.Start();
            _player = new GameObject(300, 300);
            _enemies = new List<GameObject>();
            _pressedKeys = new List<Keys>();

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        // プレイヤーの操作で動く点を作る。
        private int _x;
        private int _y;
        private GameObject _player;
        private List<GameObject> _enemies;
        private List<Keys> _pressedKeys;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!_pressedKeys.Contains(e.KeyCode)) _pressedKeys.Add(e.KeyCode);
            switch (e.KeyCode)
            {
                case Keys.Back:
                    _scene = Scene.Title;
                    break;
                case Keys.Space:
                    _scene = Scene.GameMain;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            _pressedKeys.Remove(e.KeyCode);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var key in _pressedKeys)
            {
                Console.Write(key + ", ");
            }

            if (_pressedKeys.Contains(Keys.Right)) _player.Move(5, 0);
            if (_pressedKeys.Contains(Keys.Left)) _player.Move(-5, 0);
            if (_pressedKeys.Contains(Keys.Up)) _player.Move(0, -5);
            if (_pressedKeys.Contains(Keys.Down)) _player.Move(0, 5);

            foreach (var enemy in _enemies) enemy.RandomWalk();
            foreach (var enemy in _enemies)
            {
                if (_player.Intersects(enemy))
                {
                    enemy.Die();
                }
            }

            _graphics.Clear(Color.White);
            if (_scene == Scene.GameMain)
            {
                _player.Draw(_graphics);
                foreach (var enemy in _enemies)
                {
                    if (enemy.IsAlive) enemy.Draw(_graphics);
                }
            }
            else if (_scene == Scene.Title)
            {
                _graphics.DrawString("Title scene", new Font("MS UI Gothic", 20), Brushes.Black, 200, 200);
            }
            pictureBox1.Image = _bmp;
            pictureBox1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            var x = rand.Next(300);
            var y = rand.Next(300);
            var enemy = new GameObject(x, y);
            _enemies.Add(enemy);
        }
    }
}