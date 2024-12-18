### Please note before start reading
Those code examples about design pattern have the purpose of personal use, to easily remember the patters; it's like a notepad. I took the following examples from Youtube and some web articles.

The major source of the examples is a Youtube channel of [DoableDanny](https://www.youtube.com/@doabledanny/videos), he's a very good developer. I suggest to all to buy 📒his book about design pattern 📒 , it's very clear.

# Factory pattern
 Factory method define an interface for creating object. \
 The subclasses can alter the type of objects that will be created. \
 It relies on inheritance and polymorphism to add program flexibility. \
 Using the Factory method pattern, we can defer the creation of an object to subclasses, and this is possible through inheritance. \
 Create object without exposing the creation logic to the client and refer to newly created object using a common interface. \
 The major goals are:
- encapulating object creation
- central point of control and configuration
- open - closed principle
- testing and mocking of client code
  
I can use the same factory object, with inside its buildin logics, to create N object across the program.