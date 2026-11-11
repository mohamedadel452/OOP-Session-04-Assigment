<div dir="rtl">

# 💻 البرمجة كائنية التوجه — المحاضرة 04: التجريد (Abstraction)، الفئات المجردة، والواجهات (Smart Delivery Part 3)
### OOP Session 04: Abstraction, Abstract Classes & Interfaces Architecture (Smart Delivery Part 3)

[![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-14.0-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![Module](https://img.shields.io/badge/Module-02_OOP-0284c7?style=for-the-badge)](#)
[![Interactive Guide](https://img.shields.io/badge/%F0%9F%8C%90_Live_Study_Guide-HTML_Interactive-8b5cf6?style=for-the-badge)](https://htmlpreview.github.io/?https://github.com/mohamedadel452/OOP-Session-04-Assigment/blob/master/Study_Guide/OOP_Session04_Deep_Dive.html)

> **نبذة عن المشروع:** 🚀 [02 OOP - Session 04] Smart Delivery System (Part 3 - 12 Source Files): Abstract Shipment Class, ITrackable & IInsurable Interfaces, Explicit/Implicit Implementation & Decoupled Polymorphism.

---

## 🌐 الدليل التفاعلي المشروح بالـ HTML (Interactive Study Guide)

تم تضمين الدليل التفاعلي المشروح بالكامل داخل مجلد [`Study_Guide/`](./Study_Guide) في هذا المستودع، ويمكنك قراءته مباشرة في المتصفح عبر الروابط التالية:

- 🌐 الدليل التفاعلي الشامل: OOP Session 04 — Abstraction & Interfaces (HTML): **[🌐 معاينة حية في المتصفح (Live Preview)](https://htmlpreview.github.io/?https://github.com/mohamedadel452/OOP-Session-04-Assigment/blob/master/Study_Guide/OOP_Session04_Deep_Dive.html)** | **[📄 فتح ملف الـ HTML في المستودع](./Study_Guide/OOP_Session04_Deep_Dive.html)**
- 📂 **[فتح مجلد المحاضرة المحلي الكامل في `nots` (للتصفح المحلي على الجهاز)](../../../../nots/02_OOP/Session_04_Abstraction_&_Interfaces)**

---

### 🧠 الملاحظات الهندسية والمفاهيم المعمارية (Engineering Notes)
1. **متى نستخدم `abstract class` ومتى نستخدم `interface`؟**
   - **`abstract class Shipment` (علاقة `IS-A`):** يمثل الهوية الأساسية المشتركة لجميع الشحنات، ويحتوي على حالة مشتركة (`Fields / Properties`) وبانٍ (`Constructor`) ودوال مجردة (`abstract decimal CalculateBaseCost()`). لا يمكن إنشاء كائن مباشر من `Shipment` لأنفه مفهوم مجرد.
   - **`interface ITrackable` و `interface IInsurable` (علاقة `CAN-DO`):** عقود سلوكية تمنح قدرات إضافية (التتبع والتأمين) لأي كلاس يطبقها، وتسمح للكلاس بتطبيق عدة واجهات في آنٍ واحد (`Multiple Interface Inheritance`).
2. **فصل الملفات المعماري (12 ملف كود مستقل):**
   - تم تقسيم المشروع وفق معايير هندسة البرمجيات الاحترافية بحيث يكون كل كلاس وواجهة في ملف `.cs` مستقل لسهولة الصيانة والتوسع.

---

## 🗂️ هيكلة الكود والتمارين التطبيقية المحلولة

| الملف المصدري | النوع | المسؤولية المعمارية |
| :--- | :--- | :--- |
| [`ITrackable.cs`](./OOP04_SmartDelivery/ITrackable.cs) | `interface` | عقد تتبع الشحنات (`TrackingStatus`, `UpdateTrackingStatus`, `GetTrackingHistory`). |
| [`IInsurable.cs`](./OOP04_SmartDelivery/IInsurable.cs) | `interface` | عقد التأمين على الشحنات (`InsuranceCoverage`, `CalculateInsuranceFee`). |
| [`Shipment.cs`](./OOP04_SmartDelivery/Shipment.cs) | `abstract class` | الكلاس الأب المجرد الذي يطبق `ITrackable` ويفرض العقد على جميع الشحنات. |
| [`StandardShipment.cs`](./OOP04_SmartDelivery/StandardShipment.cs) | `class` | تنفيذ الشحنة القياسية الموروثة من `Shipment`. |
| [`ExpressShipment.cs`](./OOP04_SmartDelivery/ExpressShipment.cs) | `class` | شحنة سريعة تطبق `IInsurable` بالإضافة لوراثة `Shipment`. |
| [`InternationalShipment.cs`](./OOP04_SmartDelivery/InternationalShipment.cs) | `class` | شحنة دولية تطبق `IInsurable` وتدير التخليص الجمركي. |
| [`PriorityInternationalShipment.cs`](./OOP04_SmartDelivery/PriorityInternationalShipment.cs) | `class` | شحنة دولية عاجلة بدوال مختومة `sealed override`. |
| [`CompletedShipment.cs`](./OOP04_SmartDelivery/CompletedShipment.cs) | `sealed class` | شحنة مغلقة نهائياً بعد التسليم. |
| [`DeliveryCenter.cs`](./OOP04_SmartDelivery/DeliveryCenter.cs) | `class` | إدارة الشحنات ومعالجتها بشكل متعدد الأشكال عبر `Shipment` و `ITrackable` و `IInsurable`. |
| [`Driver.cs`](./OOP04_SmartDelivery/Driver.cs) / [`DeliveryReport.cs`](./OOP04_SmartDelivery/DeliveryReport.cs) / [`DeliveryAddress.cs`](./OOP04_SmartDelivery/DeliveryAddress.cs) | Domain Models | نماذج السائق، التقرير، والعنوان. |

---

## 🧭 خريطة مسار هندسة `.NET` الكامل على GitHub

| # | المرحلة (Module) | المستودع (Repository) | الموضوع الرئيسي | الدليل التفاعلي (Live HTML) |
| :---: | :--- | :--- | :--- | :---: |
| **01** | `01_CSharp_Basics` | **[`CSharp-Basics02-Assigment`](https://github.com/mohamedadel452/CSharp-Basics02-Assigment)** | أنواع البيانات، نموذج الكائنات (System.Object)، والتحويلات | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/CSharp-Basics02-Assigment/blob/master/Study_Guide/CSharp_Basics_Session02_Guide.html) |
| **02** | `01_CSharp_Basics` | **[`CSharp-Basics03-Assigment`](https://github.com/mohamedadel452/CSharp-Basics03-Assigment)** | معمارية النصوص (Strings & StringBuilder)، جمل التحكم، والحلقات | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/CSharp-Basics03-Assigment/blob/master/Study_Guide/CSharp_Basics_Session03_Guide.html) |
| **03** | `01_CSharp_Basics` | **[`CSharp-Basics04-Assigment`](https://github.com/mohamedadel452/CSharp-Basics04-Assigment)** | المصفوفات (1D & 2D Arrays) وتمرير المعاملات للدوال (Value / ref / out / params) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/CSharp-Basics04-Assigment/blob/master/Study_Guide/CSharp_Basics_Session04_Guide.html) |
| **04** | `01_CSharp_Basics` | **[`CSharp-Basics05-Assigment`](https://github.com/mohamedadel452/CSharp-Basics05-Assigment)** | محددات الوصول (Access Modifiers)، التغليف، والـ Enums | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/CSharp-Basics05-Assigment/blob/master/Study_Guide/CSharp_Basics_Session05_Guide.html) |
| **05** | `02_OOP` | **[`OOP-Session-01-Assigment`](https://github.com/mohamedadel452/OOP-Session-01-Assigment)** | الـ Struct، التغليف، الخصائص، والـ Indexers (نظام Smart Delivery) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/OOP-Session-01-Assigment/blob/master/Study_Guide/OOP_Session01_Deep_Dive.html) |
| **06** | `02_OOP` | **[`OOP-Session-02-Assigment`](https://github.com/mohamedadel452/OOP-Session-02-Assigment)** | الفئات (Classes)، الوراثة، وتسلسل الـ Constructors (Smart Delivery Part 1) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/OOP-Session-02-Assigment/blob/master/Study_Guide/OOP_Session02_Deep_Dive.html) |
| **07** | `02_OOP` | **[`OOP-Session-03-Assigment`](https://github.com/mohamedadel452/OOP-Session-03-Assigment)** | تعدد الأشكال (Polymorphism)، الربط الديناميكي، والكلاسات المختومة (Sealed) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/OOP-Session-03-Assigment/blob/master/Study_Guide/OOP_Session03_04_Dispatch_&_SOLID_Deep_Dive.html) |
| **08** | `02_OOP` | **[`OOP-Session-04-Assigment`](https://github.com/mohamedadel452/OOP-Session-04-Assigment)** | التجريد (Abstraction)، الفئات المجردة، والواجهات (Smart Delivery Part 3) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/OOP-Session-04-Assigment/blob/master/Study_Guide/OOP_Session04_Deep_Dive.html) |
| **09** | `02_OOP` | **[`OOP-Session-05-Assigment`](https://github.com/mohamedadel452/OOP-Session-05-Assigment)** | نسخ الكائنات، Static، دوال التوسيع، والـ Partial Classes (Smart Delivery Final) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/OOP-Session-05-Assigment/blob/master/Study_Guide/OOP_Session05_Deep_Dive.html) |
| **10** | `03_Advanced_CSharp` | **[`Advanced-CSharp-01`](https://github.com/mohamedadel452/Advanced-CSharp-01)** | الأنواع المعممة (Generics)، القيود (Constraints)، والـ Variance | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/Advanced-CSharp-01/blob/master/Study_Guide/Generics_Deep_Part1_Core.html) |
| **11** | `03_Advanced_CSharp` | **[`Advanced-CSharp-02`](https://github.com/mohamedadel452/Advanced-CSharp-02)** | المفوضات (Delegates)، تعبيرات Lambda، ونظام ShopMaster | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/Advanced-CSharp-02/blob/master/Study_Guide/Delegates_Part1_Core.html) |
| **12** | `03_Advanced_CSharp` | **[`Advanced-CSharp-03`](https://github.com/mohamedadel452/Advanced-CSharp-03)** | معمارية هياكل البيانات والـ Collections (6 أنظمة تطبيقية) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/Advanced-CSharp-03/blob/master/Study_Guide/session03-part1-collections-list.html) |
| **13** | `04_Database` | **[`Database-Session-01-Assigment`](https://github.com/mohamedadel452/Database-Session-01-Assigment)** | تصميم قواعد البيانات، مخططات الـ ERD، والتحويل العلائقي (Relational Mapping) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/Database-Session-01-Assigment/blob/master/Study_Guide/ERD_Part1_Design_Intro.html) |

---

## 🚀 طريقة التشغيل المحلي (How to Run)

```bash
git clone https://github.com/mohamedadel452/OOP-Session-04-Assigment.git
cd OOP-Session-04-Assigment
dotnet run --project "OOP04_SmartDelivery/OOP04_SmartDelivery.csproj"
```

**إعداد وتطوير:** [محمد عادل محمد بيومي (mohamedadel452)](https://github.com/mohamedadel452) — كلية الحاسبات والمعلومات، جامعة عين شمس.

</div>
