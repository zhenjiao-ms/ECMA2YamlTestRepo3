using namespace System;
using namespace System::Reflection;

public ref class Program
{

public:
    // Methods to get:

    void MethodA(int i, int j) { }

    void MethodA(array<int>^ iarry) { }

    void MethodA(double *ip) { }

    // Method that takes a managed reference paramter.
    void MethodA(int% r) {}
};

int main()
{
    MethodInfo^ mInfo;


    // Get MethodA(int i, int j)
    mInfo = Program::typeid->GetMethod("MethodA",
        BindingFlags::Public | BindingFlags::Instance,
        nullptr,
        CallingConventions::Any,
        gcnew array<Type^> {int::typeid, int::typeid},
        nullptr);
    Console::WriteLine("Found method: {0}", mInfo );

    // Get  MethodA(array<int>^ iarry)
    mInfo = Program::typeid->GetMethod("MethodA",
        BindingFlags::Public | BindingFlags::Instance,
        nullptr,
        CallingConventions::Any,
        gcnew array<Type^> {int::typeid->MakeArrayType()},
        nullptr);
    Console::WriteLine("Found method: {0}", mInfo );

    // Get MethodA(double *ip)
    mInfo = Program::typeid->GetMethod("MethodA",
        BindingFlags::Public | BindingFlags::Instance,
        nullptr,
        CallingConventions::Any,
        gcnew array<Type^> {double::typeid->MakePointerType()},
        nullptr);
    Console::WriteLine("Found method: {0}", mInfo );

    // Get MethodA(int% r)
    mInfo = Program::typeid->GetMethod("MethodA",
        BindingFlags::Public | BindingFlags::Instance,
        nullptr,
        CallingConventions::Any,
        gcnew array<Type^> {int::typeid->MakeByRefType()},
        nullptr);
    Console::WriteLine("Found method: {0}", mInfo );

}