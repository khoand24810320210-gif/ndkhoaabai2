DROP TABLE IF EXISTS DangKy;
DROP TABLE IF EXISTS KhoaHoc;

CREATE TABLE KhoaHoc (
    MaKhoaHoc VARCHAR(20) PRIMARY KEY,
    TenKhoaHoc NVARCHAR(100) NOT NULL 
);


INSERT INTO KhoaHoc (MaKhoaHoc, TenKhoaHoc) VALUES 
('C#', N'Lập trình C# WinForms'),
('WEB', N'Lập trình Web ASP.NET'),
('SQL', N'Quản trị Cơ sở dữ liệu SQL Server');

CREATE TABLE DangKy (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100),
    SoDienThoai VARCHAR(20),
    NgaySinh DATE,
    MaKhoaHoc VARCHAR(20),
    FOREIGN KEY (MaKhoaHoc) REFERENCES KhoaHoc(MaKhoaHoc)
);