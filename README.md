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

