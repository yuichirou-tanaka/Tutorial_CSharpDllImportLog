#include <iostream>


#ifdef __cplusplus
#define DLLEXPORT extern "C" __declspec(dllexport)
#else
#define DLLEXPORT __declspec(dllexport)
#endif

using namespace std;




DLLEXPORT int __stdcall multiply(int x, int y)
{
    return 2 * x + 3 * y;
}

DLLEXPORT void __stdcall multiplyUsePointer(int* x, int* y, int* result)
{
    *result = 2 * (*x) + 3 * (*y);
}


static string _str = "";
static wstring _wstr = L"";

DLLEXPORT void __stdcall setNameString(const char* str)
{
    DebugLog(str);
    _str = string(str);
}

DLLEXPORT const char* __stdcall getNameString()
{
    return _str.c_str();
}

DLLEXPORT void __stdcall setNameWString(const wchar_t* str)
{
    _wstr = wstring(str);
}

DLLEXPORT const wchar_t* __stdcall getNameWString()
{
    return _wstr.c_str();
}


void main() {
	using namespace std;
	cout << "Ok" << endl;
    TestCallLog();
	return;
}

