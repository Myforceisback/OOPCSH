#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <Windows.h>

typedef struct _sMusic
{
    int sStud;
    wchar_t sNameFilm[100];
    wchar_t sProd[100];
    wchar_t sGenre[100];
    wchar_t sNameMusic[100];
    wchar_t sNameClass[100];
} sMusic;
typedef struct _sActors
{
    int sStud;
    wchar_t sNameFilm[100];
    wchar_t sProd[100];
    wchar_t sGenre[100];
    wchar_t sNameActor[100];
    wchar_t sNameClass[100];
} sActors;
typedef struct _sCompositor
{
    int sStud;
    wchar_t sNameFilm[100];
    wchar_t sProd[100];
    wchar_t sGenre[100];
    wchar_t sNameMusic[100];
    wchar_t sNameCompositor[100];
    wchar_t sNameClass[100];
} sCompositor;

extern "C" __declspec(dllexport) bool InpMus(sMusic * cl);
extern "C" __declspec(dllexport) bool InpAct(sActors * cl);
extern "C" __declspec(dllexport) bool InpCom(sCompositor * cl);
extern "C" __declspec(dllexport) bool OtpMus(sMusic * cl);
extern "C" __declspec(dllexport) bool OtpAct(sActors * cl);
extern "C" __declspec(dllexport) bool OtpCom(sCompositor * cl);
extern "C" __declspec(dllexport) void intFilm(int& Stud);
extern "C" __declspec(dllexport) void strFilm(wchar_t* NameFilm, wchar_t* Prod, wchar_t* Genre);

bool InpMus(sMusic* cl) {
    printf("NameFilm(string) - ");
    scanf("%ls", cl->sNameFilm);

    printf("Studio(int) - ");
    scanf("%d", &cl->sStud);
    
    printf("Production(string) - ");
    scanf("%ls", cl->sProd);
    
    printf("Genre(string) - ");
    scanf("%ls", cl->sGenre);
    
    printf("NameMusic(string) - ");
    scanf("%ls", cl->sNameMusic);

    wcscpy(cl->sNameClass, L"Music class");
    return true;
}
bool OtpMus(sMusic* cl) {
    printf("Music class\n");
    printf("NameFilm - %S\n", cl->sNameFilm);
    printf("Studio - %d\n", cl->sStud);
    printf("Production - %S\n", cl->sProd);
    printf("Genre - %S\n", cl->sGenre);
    printf("NameMusic - %S\n", cl->sNameMusic);
    return true;
}
bool InpAct(sActors* cl) {
    printf("NameFilm(string) - ");
    scanf("%ls", cl->sNameFilm);

    printf("Studio(int) - ");
    scanf("%d", &cl->sStud);

    printf("Production(string) - ");
    scanf("%ls", cl->sProd);

    printf("Genre(string) - ");
    scanf("%ls", cl->sGenre);

    printf("NameActors(string) - ");
    scanf("%ls", cl->sNameActor);

    wcscpy(cl->sNameClass, L"Music class");
    return true;
}
bool OtpAct(sActors* cl) {
    printf("Actor class\n");
    printf("NameFilm - %S\n", cl->sNameFilm);
    printf("Studio - %d\n", cl->sStud);
    printf("Production - %S\n", cl->sProd);
    printf("Genre - %S\n", cl->sGenre);
    printf("NameActor - %S\n", cl->sNameActor);
    return true;
}
bool InpCom(sCompositor* cl) {
    printf("NameFilm(string) - ");
    scanf("%ls", cl->sNameFilm);

    printf("Studio(int) - ");
    scanf("%d", &cl->sStud);

    printf("Production(string) - ");
    scanf("%ls", cl->sProd);

    printf("Genre(string) - ");
    scanf("%ls", cl->sGenre);

    printf("NameMusic(string) - ");
    scanf("%ls", cl->sNameMusic);

    printf("NameCompositor(string) - ");
    scanf("%ls", cl->sNameCompositor);

    wcscpy(cl->sNameClass, L"Music class");
    return true;
}
bool OtpCom(sCompositor* cl) {
    printf("Compositor class\n");
    printf("NameFilm - %S\n", cl->sNameFilm);
    printf("Studio - %d\n", cl->sStud);
    printf("Production - %S\n", cl->sProd);
    printf("Genre - %S\n", cl->sGenre);
    printf("NameMusic - %S\n", cl->sNameMusic);
    printf("NameCompositor - %S\n", cl->sNameCompositor);
    return true;
}

void intFilm(int &Stud) {
    printf("Studio(int) - ");
    scanf("%d", &Stud);
}
void strFilm(wchar_t* NameFilm, wchar_t* Prod, wchar_t* Genre) {
    wchar_t _Name[100], _Prod[100], _Genre[100];
    printf("NameFilm(string) - ");
    scanf("%ls", _Name);
    printf("Production(string) - ");
    scanf("%ls", _Prod);
    printf("Genre(string) - ");
    scanf("%ls", _Genre);
    wcscpy(NameFilm, _Name);
    wcscpy(Prod, _Prod);
    wcscpy(Genre, _Genre);
}
