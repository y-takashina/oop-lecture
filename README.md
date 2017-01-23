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

```
        public bool Intersects(GameObject obj)
        {
            return X < obj.X + obj.W && X + W > obj.X &&
                   Y < obj.Y + obj.H && Y + H > obj.Y;
        }
```


