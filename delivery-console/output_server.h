#pragma once
#include <windows.h>
#include <cstdlib>
#include <fstream>
#include <vector>
#include "../delivery-model/model.h"
#include "../delivery-model/point.h" 


static const char* BLANK = "                ";
//����������н��
class OutputServer {
 public:
  std::ofstream OutFile;

  OutputServer();
  ~OutputServer();
  void PrintToConsole(const Model &m);  //��ӡ������̨
  void PrintToFile(const Model &m);     //��ӡ���ļ�
  void EndPrint(const Model &m);                 //��ӡ��ӭ����
 private:
  void gotoxy(short x, short y);
};
