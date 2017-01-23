# oop-lecture
オブジェクト指向教える用。C#。

## Snipets

```cs
protected override void OnMouseDown(MouseEventArgs e)
{
    if (!_pressedButtons.Contains(e.Button)) _pressedButtons.AddLast(e.Button);
}

protected override void OnMouseUp(MouseEventArgs e)
{
    _pressedButtons.Remove(e.Button);
}
```

