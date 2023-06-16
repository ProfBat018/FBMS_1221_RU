# Тема урока. Includes, часть 2.

Мы с вами уже знаем что есть 3 способа работы с многотабличными БД:
* Eager loading
* Lazy loading
* Explicit loading

Все эти способы мы рассмотрели в предыдущем уроке. Но есть еще один способ, который мы не рассмотрели. Это способ, который позволяет нам загружать данные из нескольких таблиц в один объект. Этот способ называется **Includes**.

Методы, которые нам надо рассмотреть в Eager loading:
* Include
* ThenInclude
* IncludeFilter
* IncludeWithOne
* IncludeWithZeroOrOne

### Include - включает в себя все данные из другой таблицы
```csharp
var blogs = context.Blogs
    .Include(blog => blog.Posts)
    .ToList();
```

Тут мы включаем все посты, которые есть в блогах. То есть мы получаем все блоги и все посты, которые есть в этих блогах.

### ThenInclude - включает в себя все данные из другой таблицы, которая включена в первую таблицу
```csharp
var blogs = context.Blogs
    .Include(blog => blog.Posts)
        .ThenInclude(post => post.Author)
    .ToList();
```

Тут мы включаем все посты, которые есть в блогах, а также включаем авторов, которые есть в этих постах.

### IncludeFilter - включает в себя все данные из другой таблицы, но с фильтром

```csharp
var blogs = context.Blogs
    .Include(blog => blog.Posts.Where(post => post.Title.Contains("First")))
    .ToList();
```


### IncludeWithOne - включает в себя все данные из другой таблицы, которая имеет связь OneToOne

```csharp
var blogs = context.Blogs
    .Include(blog => blog.Posts)
        .ThenInclude(post => post.Author)
            .ThenInclude(author => author.Photo)
    .ToList();
```


### IncludeWithZeroOrOne 

```csharp
var comps = context.Computers.
            .Include(c => c.PC)
            .ThenInclude(pc => pc.Printer);
```


## Lazy loading.
Тут нет никакиз методов, главное помните про proxies и virtual.

## Explicit loading.
Тут из методов только: 
* Load
* Collection
* Reference
* Entry
* Query

Ничего нового тут нет. Смотрите примеры с прошлого урока XD 

Так как Лала забыла Query, то вот пример:
```csharp
var blog = context.Blogs.Single(b => b.BlogId == 1);

context.Entry(blog)
    .Collection(b => b.Posts)
    .Query()
    .Where(p => p.Title.Contains("Cheese"))
    .Load();
```

Query - это метод, который позволяет сделать под-фильтрацию. То есть мы можем выбрать все посты, которые содержат в себе слово "Cheese".

Аналог - это IncludeFilter

```csharp

// include filter

var blogs = context.Blogs
    .Include(blog => blog.Posts.Where(post => post.Title.Contains("First")))
    .ToList();

```