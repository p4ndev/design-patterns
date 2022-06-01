
using Builder;

MenuBuilder wrapper;
Menu result;

// Kids menu
wrapper = new KidsMenuBuilder();
wrapper.Build();
result = wrapper.GetResult();
Console.WriteLine(result);
