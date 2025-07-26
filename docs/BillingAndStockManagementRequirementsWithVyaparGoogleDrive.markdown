# Requirements Document for Billing and Stock Management App with Vyapar-Inspired Features and Google Drive Integration

## 1. Introduction
This document outlines the requirements for a cross-platform billing and stock management application for small to medium-sized merchant stores in India, developed using .NET MAUI Blazor with free and open-source tools. The app will support Windows 7 SP1 and later, Android (5.0+), iOS (11+), and macOS (10.15+), delivering a responsive, web-based UI with native capabilities. Inspired by the Vyapar app, it includes features like GST-compliant invoicing, inventory tracking, and WhatsApp sharing, using MudBlazor Charts for data visualization seorang Google Drive for cloud storage and backup (15 GB free tier).

## 2. Purpose
The app aims to streamline billing, inventory, and accounting tasks for Indian merchants, with the following objectives:
- **Ease of Use**: Intuitive, web-like interface requiring no advanced accounting knowledge.
- **GST Compliance**: Adhere to Indian GST regulations for accurate tax calculations and reporting.
- **Cross-Platform Support**: Seamless operation on Windows, Android, iOS, and macOS.
- **Free Tools**: Use only open-source/free services (e.g., MudBlazor, jsPDF, Google Drive).
- **Offline Capability**: Support offline operations with cloud synchronization via Google Drive.
- **Vyapar-Inspired Features**: Incorporate customizable invoices, payment reminders, barcode generation, and more.

## 3. Scope
The app will provide comprehensive billing, stock management, and accounting features, including Vyapar’s popular functionalities such as customizable invoices, WhatsApp sharing, and inventory reports. It will use Google Drive’s free tier for cloud storage and backup, replacing Supabase, and other free tools like MudBlazor Charts and jsPDF. The system will support offline operations and synchronize data with Google Drive, targeting retail, wholesale, and supermarket merchants in India.

## 4. Functional Requirements
The requirements incorporate Vyapar’s features, adapted for .NET MAUI Blazor with Google Drive for cloud storage.

### 4.1 Billing Module
- **FR-B1: Invoice Generation** *(Vyapar: Customizable GST invoices, multiple formats)*
  - Create GST-compliant invoices (CGST, SGST, IGST) with auto-filled item details (e.g., name, price, HSN code).
  - Offer 5+ customizable invoice formats using Razor components and MudBlazor styling.
  - Include fields: customer details, itemized products, discounts, taxes, total, and business logo.
  - Export invoices as PDF using jsPDF and share via WhatsApp/SMS/email using MAUI’s native sharing APIs.
  - Support shortcut keys for faster billing (e.g., auto-fill items by SKU).
- **FR-B2: Payment Processing** *(Vyapar: Multiple payment modes, payment reminders)*
  - Record payments manually (cash, UPI, card, bank transfer) with fields for type, amount, and date.
  - Support multiple payment modes with manual entry for customer preferences.
  - Send payment reminders via WhatsApp/SMS/email for overdue invoices, including PDF links.
  - Track payment status (paid, partial, overdue) and display on dashboard.
- **FR-B3: GST Compliance** *(Vyapar: GST reports, e-invoicing)*
  - Calculate GST automatically based on configurable HSN codes and tax rates.
  - Generate CSV reports for GST return filing (e.g., GSTR-1, GSTR-3B).
  - Support multi-state taxes (IGST) for inter-state transactions.
  - Provide basic e-invoicing capabilities compliant with Indian regulations.
- **FR-B4: Discounts and Promotions** *(Vyapar: Flexible discounts)*
  - Apply item-level or invoice-level discounts (percentage or fixed amount).
  - Support promotional schemes (e.g., buy-one-get-one, loyalty discounts).
- **FR-B5: Customer Management** *(Vyapar: Party management)*
  - Store customer details (name, phone, email, address) with purchase history.
  - Categorize customers as registered (regular/composition) or unregistered for GST purposes.
  - Implement basic loyalty program with point tracking.

### 4.2 Stock Management Module
- **FR-S1: Inventory Tracking** *(Vyapar: Barcode generation, low stock alerts)*
  - Update stock levels in real-time (add, edit, delete) using Razor components.
  - Generate and scan barcodes for items using ZXing.Net.Maui (free).
  - Set low-stock alerts with configurable thresholds and reorder suggestions.
  - Track stock by batch number, expiry date, manufacturing date, and slot number.
- **FR-S2: Product Management** *(Vyapar: Categorization, batch tracking)*
  - Manage products with attributes: name, SKU, price, HSN code, category, unit (e.g., kg, pieces).
  - Support batch tracking and expiry date alerts for perishables.
  - Allow Excel/CSV import for bulk product creation.
- **FR-S3: Supplier Management** *(Vyapar: Purchase order tracking)*
  - Store supplier details (name, contact, address) and purchase history.
  - Generate and track purchase orders with status (pending, fulfilled).
  - Record supplier invoices with payment status.
- **FR-S4: Stock Reports** *(Vyapar: Comprehensive reports)*
  - Generate reports: daily/weekly/monthly stock movements, stock valuation, wastage.
  - Include low-stock and expiry reports for proactive inventory management.
  - Export reports in CSV or PDF (via jsPDF).

### 4.3 Additional Features
- **FR-A1: Multilingual Support** *(Vyapar: Multi-language transaction messages)*
  - Support English, Hindi, Tamil, Telugu, and Bengali using Noto Serif fonts (free).
  - Allow dynamic language switching via UI.
  - Send transaction messages (e.g., invoices, reminders) in selected languages via WhatsApp/SMS.
- **FR-A2: Offline Mode** *(Vyapar: Offline billing)*
  - Enable billing and stock updates offline using SQLite and Blazored.LocalStorage.
  - Synchronize data with Google Drive (free tier) when online, storing backups as JSON/CSV files.
  - Support auto-backup to Google Drive for data recovery.
- **FR-A3: User Management** *(Vyapar: Multiple user roles)*
  - Support role-based access: admin (full access), cashier (billing only), inventory manager (stock only).
  - Implement login system using ASP.NET Identity (free) with customizable permissions.
  - Log user activities (e.g., invoice creation, stock updates).
- **FR-A4: Data Visualization** *(Vyapar: Business reports)*
  - Display charts for sales trends, stock levels, expenses, and receivables using MudBlazor Charts (line, bar, pie).
  - Provide a dashboard showing cash-in-hand, stock value, and receivables/payables.
  - Include 10+ report types (e.g., sales, low stock, profit/loss) inspired by Vyapar’s 30+ reports.
- **FR-A5: Notifications** *(Vyapar: Payment reminders, low stock alerts)*
  - Show in-app alerts (e.g., low stock, overdue payments) using MudBlazor Toast notifications.
  - Send push notifications for critical events via MAUI’s native APIs.
  - Support WhatsApp/SMS reminders for payments and stock alerts.
- **FR-A6: Cloud Integration** *(Vyapar: Data sync across devices)*
  - Sync data with Google Drive (15 GB free tier) for cloud storage and multi-device access.
  - Use Google Drive APIs to upload/download JSON/CSV files for backups and sync.
  - Implement JWT-based authentication for secure local user management.
- **FR-A7: Online Store Integration** *(Vyapar: Free online store)*
  - Create a basic online store interface for sharing product catalogs via WhatsApp.
  - Allow customers to place orders via WhatsApp or email links.
- **FR-A8: Delivery Challan** *(Vyapar: Delivery challan tracking)*
  - Generate delivery challans for goods dispatched to customers.
  - Track challan status (e.g., delivered, pending) with location-based notes.

## 5. Non-Functional Requirements
- **NFR-1: Performance** *(Vyapar: Fast billing)*
  - Ensure app responsiveness on low-end devices (e.g., 2GB RAM Android phones).
  - Optimize WebView rendering for Windows 7 using .NET Framework 4.8.
  - Load dashboard and MudBlazor Charts within 2 seconds under normal conditions.
- **NFR-2: Compatibility** *(Vyapar: Mobile and desktop support)*
  - Support Windows 7 SP1 and later (using legacy WebView).
  - Support Android 5.0 (API 21) and later, iOS 11 and later, macOS 10.15 and later.
  - Ensure responsive UI for screen sizes from 320px (mobile) to 1920px (desktop).
- **NFR-3: Security** *(Vyapar: Data security)*
  - Store sensitive data (e.g., customer details, credentials) using MAUI’s SecureStorage.
  - Encrypt JSON/CSV files before uploading to Google Drive.
  - Use JWT tokens for local authentication (no server-side auth due to Google Drive).
- **NFR-4: Scalability**
  - Handle up to 10,000 products and 1,000 invoices/month within Google Drive’s 15 GB free tier.
  - Support multi-user access (up to 10 concurrent users) with local authentication.
- **NFR-5: Usability** *(Vyapar: Simple UI, no accounting knowledge needed)*
  - Provide a web-like, intuitive UI using MudBlazor components.
  - Ensure accessibility (e.g., high-contrast mode, readable fonts).
  - Support right-to-left scripts (e.g., Urdu) if needed.
- **NFR-6: Reliability**
  - Ensure 99.9% reliability for local data storage and Google Drive sync.
  - Prevent data loss during offline/online transitions with auto-backup.
- **NFR-7: Maintainability**
  - Use MVVM pattern with CommunityToolkit.Mvvm for modular code.
  - Document code and provide user guides for merchants.

## 6. Constraints
- **Free Tools Only**: Use open-source/free tools (e.g., MudBlazor, jsPDF, Google Drive APIs).
- **No Paid Payment Gateways**: Manual payment recording due to lack of free UPI/card APIs.
- **Windows 7 Support**: Limited by legacy WebView; avoid WebView2 dependencies.
- **Google Drive Limits**: 15 GB free tier storage; no built-in database or real-time APIs.
- **Internet Dependency**: Offline mode required for unreliable connectivity areas.
- **iOS Support**: Ensure compatibility, as Vyapar lacks iOS support in some reviews.

## 7. Assumptions
- Merchants have Google accounts for Google Drive access.
- Users are familiar with basic smartphone/PC operations.
- Google Drive’s 15 GB free tier is sufficient for initial scale (JSON/CSV backups).
- Manual payment recording is acceptable until free payment APIs are available.
- Barcode scanners or device cameras are available for stock management.

## 8. Stakeholders
- **Merchants**: Primary users (retail, wholesale, supermarket owners).
- **Cashiers/Inventory Managers**: Role-specific users.
- **Accountants**: Use GST reports for tax filing.
- **Developers**: Maintain and update the app.
- **Customers**: Benefit from invoices, loyalty programs, and online store.

## 9. Technical Requirements
- **Framework**: .NET MAUI Blazor (.NET 8, free).
- **IDE**: Visual Studio 2022 Community Edition (free).
- **Database**: SQLite (local, free).
- **Cloud Storage**: Google Drive (15 GB free tier) for JSON/CSV backups and sync.
- **Libraries** (all free):
  - MudBlazor: Responsive UI components and charts (line, bar, pie).
  - jsPDF: PDF export for invoices and reports.
  - ZXing.Net.Maui: Barcode scanning/generation.
  - Refit: REST API calls (for potential future integrations).
  - CommunityToolkit.Mvvm: MVVM framework.
  - Blazored.LocalStorage: Offline storage.
  - ASP.NET Identity: Local authentication.
  - Google.Apis.Drive.v3: Google Drive API integration.
- **Fonts**: Google Noto Serif (free) for multilingual support:
  - Hindi: Noto Serif Devanagari
  - Tamil: Noto Serif Tamil
  - Telugu: Noto Serif Telugu
  - Bengali: Noto Serif Bengali
- **Styling**: Tailwind CSS (via free CDN).
- **Version Control**: Git with GitHub (free).

## 10. Deliverables
- Cross-platform app (Windows, Android, iOS, macOS).
- User manual for merchants and staff.
- Source code with documentation.
- Test reports for functionality and compatibility.
- CSV/PDF export templates for invoices and reports.

## 11. Acceptance Criteria
- App runs on Windows 7 SP1, Android 5.0+, iOS 11+, and macOS 10.15+.
- All functional requirements (FR-B1 to FR-A8) are implemented and tested.
- GST calculations comply with Indian tax regulations (verified with sample data).
- Offline mode supports billing and stock updates with reliable Google Drive sync.
- Multilingual UI renders correctly for English, Hindi, Tamil, Telugu, and Bengali.
- App handles 10,000 products and 1,000 invoices/month within Google Drive’s 15 GB limit.
- No paid services or tools are used.
- Vyapar-inspired features (e.g., customizable invoices, WhatsApp sharing, barcode generation) are fully functional.
- MudBlazor Charts display sales, stock, and financial data accurately.

## 12. Risks and Mitigations
- **Risk**: Windows 7 WebView limitations affect performance.
  - **Mitigation**: Optimize MudBlazor components (e.g., lazy-loading); test with .NET Framework 4.8.
- **Risk**: Google Drive’s 15 GB limit may be insufficient for large datasets.
  - **Mitigation**: Compress JSON/CSV files; advise merchants to manage storage or upgrade accounts.
- **Risk**: Lack of free payment gateways limits payment automation.
  - **Mitigation**: Manual payment recording; monitor for free APIs.
- **Risk**: Complex scripts (e.g., Devanagari) render poorly in WebView.
  - **Mitigation**: Use Noto Serif fonts; test CSS rendering.
- **Risk**: Google Drive lacks real-time database features like Supabase.
  - **Mitigation**: Use SQLite for local data management; sync JSON/CSV files periodically.

## 13. Vyapar Feature Integration Notes
Based on Vyapar reviews and descriptions:
- **Customizable Invoices**: 5+ formats with logo support, inspired by Vyapar’s 10+ formats.
- **WhatsApp Sharing**: Share invoices and reminders via WhatsApp/SMS/email using MAUI APIs.
- **Barcode Generation**: Generate/scan barcodes with ZXing.Net.Maui.
- **Payment Reminders**: Send WhatsApp/SMS reminders for overdue payments.
- **Offline Support**: Offline billing with SQLite and Google Drive sync.
- **Reports**: 10+ report types using MudBlazor Charts.
- **Online Store**: Basic catalog-sharing interface via WhatsApp.
- **Delivery Challan**: Generate and track delivery challans.
- **Limitations Addressed**: Added iOS support, MudBlazor Charts analytics, and responsive UI to address Vyapar’s gaps (e.g., no iOS, limited analytics).

## 14. References
- .NET MAUI Blazor: https://learn.microsoft.com/dotnet/maui/blazor
- MudBlazor: https://mudblazor.com
- jsPDF: https://github.com/parallax/jsPDF
- ZXing.Net.Maui: https://github.com/Redth/ZXing.Net.Maui
- Google Drive API: https://developers.google.com/drive/api
- Google Fonts (Noto Serif): https://fonts.google.com/noto
- Vyapar Reviews and Features: