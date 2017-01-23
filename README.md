# oop-lecture
オブジェクト指向教える用。C#。

## Snippets

```cs
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!_pressedKeys.Contains(e.KeyCode)) _pressedKeys.Add(e.KeyCode);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            _pressedKeys.Remove(e.KeyCode);
        }
```

```cs
        public bool Intersects(GameObject obj)
        {
            return X < obj.X + obj.W && X + W > obj.X &&
                   Y < obj.Y + obj.H && Y + H > obj.Y;
        }
```

```cs

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
```

```cs
            if (_pressedKeys.Contains(Keys.Right)) _player.Move(5, 0);
            if (_pressedKeys.Contains(Keys.Left)) _player.Move(-5, 0);
            if (_pressedKeys.Contains(Keys.Up)) _player.Move(0, -5);
            if (_pressedKeys.Contains(Keys.Down)) _player.Move(0, 5);
```

