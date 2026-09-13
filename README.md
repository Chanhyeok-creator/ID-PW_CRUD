# ID-PW CRUD

C# WinForms를 기반으로 구현한 **사용자 계정 관리 프로그램**입니다.

사용자의 ID와 Password를 파일에 저장하고, 로그인 및 계정 생성·수정·삭제 기능을 구현했습니다.

> 개인 학습 및 C# / 객체지향 프로그래밍 / 파일 입출력 / WinForms UI 구현을 목적으로 제작한 프로젝트입니다.

---

## 📌 Project Overview

### 개발 목적

* C# 기본 문법 및 객체지향 프로그래밍 학습
* Windows Forms를 이용한 GUI 프로그램 구현
* 파일 입출력(File I/O) 이해
* CRUD(Create, Read, Update, Delete) 기능 구현
* UI와 데이터 처리 로직을 분리하는 구조 연습
* Git / GitHub를 활용한 소스 코드 관리 연습

---

## 🛠️ Tech Stack

| Category        | Technology         |
| --------------- | ------------------ |
| Language        | C#                 |
| Framework       | .NET Framework 4.5 |
| UI              | Windows Forms      |
| IDE             | Visual Studio      |
| Data Storage    | Text File (`.txt`) |
| Version Control | Git / GitHub       |

---

## ✨ Features

### 1. Login

등록된 ID와 Password를 확인하여 로그인을 처리합니다.

* ID / Password 입력
* 사용자 인증
* 로그인 성공 / 실패 메시지 출력

### 2. Create Account

새로운 사용자 계정을 생성합니다.

* ID / Password 입력
* 입력값 확인
* 중복 ID 확인
* 계정 정보 저장

### 3. Update Account

기존 사용자의 Password를 변경합니다.

* ID 확인
* 기존 Password 확인
* 새로운 Password 입력
* 변경된 정보 저장

### 4. Delete Account

사용자의 ID와 Password를 확인한 후 계정을 삭제합니다.

### 5. Account List

등록된 계정 정보를 확인할 수 있습니다.

---

## 🏗️ Project Structure

```text
WindowsFormsApplication3
│
├─ Classes
│  ├─ CRUD.cs
│  ├─ User.cs
│  └─ UserManager.cs
│
├─ Forms
│  ├─ Account_List.cs
│  ├─ Admin.cs
│  ├─ Error.cs
│  └─ Controls
│     ├─ Create_Control1.cs
│     ├─ Delete_Control1.cs
│     └─ Update_Control1.cs
│
├─ Program.cs
├─ App.config
└─ WindowsFormsApplication3.csproj
```

### 주요 클래스 역할

#### `User.cs`

사용자 정보를 표현하는 클래스입니다.

```text
User
 ├─ ID
 ├─ PW
 └─ OLD_PW
```

사용자 데이터를 객체 형태로 관리하기 위해 작성했습니다.

#### `CRUD.cs`

실제 데이터 처리 로직을 담당합니다.

```text
Create → 계정 생성
Read   → 로그인 정보 확인
Update → 비밀번호 수정
Delete → 계정 삭제
```

파일 입출력을 통해 사용자 데이터를 저장하고 조회합니다.

#### `UserManager.cs`

UI와 CRUD 로직 사이에서 계정 관련 기능을 연결하는 역할을 합니다.

```text
Form
 ↓
UserManager
 ↓
CRUD
 ↓
User_Data.txt
```

#### `Forms / Controls`

사용자와 직접 상호작용하는 Windows Forms UI를 담당합니다.

```text
Admin
 ├─ Create
 ├─ Update
 ├─ Delete
 └─ Account List
```

---

## 💾 Data Storage

현재 프로젝트에서는 별도의 데이터베이스 대신 텍스트 파일을 사용합니다.

```text
User_Data.txt
```

데이터는 다음과 같은 형태로 저장됩니다.

```text
user1|password1
user2|password2
user3|password3
```

파일 기반 저장 방식을 통해 C#의 `StreamReader`, `StreamWriter` 및 파일 처리 방법을 학습했습니다.

---

## 🔄 Program Flow

### Login

```text
사용자 ID / PW 입력
        ↓
     Form1
        ↓
   UserManager
        ↓
      CRUD
        ↓
 User_Data.txt 조회
        ↓
 ID + PW 일치 여부 확인
        ↓
 로그인 성공 / 실패
```

### Account Management

```text
Admin
  │
  ├── Create → CRUD.Create()
  │
  ├── Update → CRUD.Update()
  │
  ├── Delete → CRUD.Delete()
  │
  └── List   → User_Data.txt 조회
```

---

## 📚 What I Learned

### C#

* 클래스와 객체
* 프로퍼티
* 메서드
* 조건문 / 반복문
* `enum`
* 예외 처리
* 파일 입출력
* `using`을 이용한 리소스 관리

### Windows Forms

* `Form`
* `UserControl`
* Button / TextBox / DataGridView
* 이벤트 처리
* Form 간 데이터 및 화면 전환
* `Show()` / `ShowDialog()`

### Software Structure

UI에서 직접 파일을 처리하지 않고,

```text
UI
 ↓
UserManager
 ↓
CRUD
```

와 같이 역할을 나누는 구조를 경험했습니다.

### Git / GitHub

* Repository 생성
* `.gitignore` 작성
* Git 초기화
* Commit
* Branch
* Remote Repository 연결
* Push

등 기본적인 Git/GitHub 사용 방법을 익혔습니다.

---

## 🔧 Future Improvements

현재 프로젝트는 C#과 파일 입출력을 학습하기 위한 프로젝트이므로, 실제 서비스에서 사용하기에는 개선해야 할 부분이 있습니다.

향후 다음과 같이 개선할 예정입니다.

* [ ] 텍스트 파일 대신 Database 사용
* [ ] Password 평문 저장 방식 개선
* [ ] Password Hash 적용
* [ ] 입력값 검증 강화
* [ ] 예외 처리 개선
* [ ] CRUD 결과값을 `enum` 등으로 명확하게 관리
* [ ] 파일 저장 및 수정 과정의 안정성 개선
* [ ] UI 코드와 비즈니스 로직의 추가적인 분리
* [ ] 클래스 및 메서드 명명 규칙 개선
* [ ] README 및 프로젝트 문서화 개선

---

## ⚠️ Security Note

본 프로젝트는 **학습 목적으로 제작된 프로그램**이며 현재 Password를 텍스트 파일에 평문으로 저장합니다.

따라서 실제 서비스 환경에서 사용하는 것을 목적으로 하지 않습니다.

실제 사용자 인증 시스템에서는 일반적으로 다음과 같은 방식이 필요합니다.

```text
Password
   ↓
Hash
   ↓
Database
```

또한 실제 서비스에서는 데이터베이스, 암호화/해싱, 접근 제어 및 예외 상황에 대한 보다 엄격한 보안 처리가 필요합니다.

---

## 🎯 Project Purpose

이 프로젝트를 통해 단순한 C# 문법 학습을 넘어

**UI → 데이터 처리 로직 → 파일 저장**

으로 이어지는 프로그램의 기본적인 구조를 직접 구현하는 것을 목표로 했습니다.

향후에는 이 프로젝트에서 학습한 C#과 객체지향 프로그래밍을 기반으로 **데이터베이스 연동 및 실제 업무에 가까운 SW 기능 구현**으로 확장할 예정입니다.
