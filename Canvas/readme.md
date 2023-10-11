# Тема урока: Canvas

Canvas - это элемент HTML5, который позволяет рисовать графику на веб-странице с помощью JavaScript.

Например всякие онлайн доски для рисования, онлайн редакторы фото и т.д.

## Подключение

```html
<canvas id="canvas" width="500" height="500"></canvas>
```

## Контекст

Для работы с Canvas нужно получить его контекст. Контекст - это объект, который предоставляет методы и свойства для рисования на Canvas.

```js
const canvas = document.getElementById('canvas');

const ctx = canvas.getContext('2d');
```

## Рисование

### Прямоугольник

```js

// Заливка
ctx.fillStyle = 'red';
ctx.fillRect(0, 0, 100, 100);

// Обводка

ctx.strokeStyle = 'blue';

ctx.lineWidth = 5;

ctx.strokeRect(0, 0, 100, 100);

```





