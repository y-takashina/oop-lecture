# oop-lecture
オブジェクト指向教える用。C#。

## Snippets

```cs
protected override void OnMouseDown(MouseEventArgs e)
{
    if (!_pressedButtons.Contains(e.Button)) _pressedButtons.Add(e.Button);
}

protected override void OnMouseUp(MouseEventArgs e)
{
    _pressedButtons.Remove(e.Button);
}
```

```
        public bool Intersects(GameObject obj)
        {
            return X < obj.X + obj.W && X + W > obj.X &&
                   Y < obj.Y + obj.H && Y + H > obj.Y;
        }
```


