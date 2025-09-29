using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorMange.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDataToDepartments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Departments (Name, Description, OrderIndex, IsActive, CreatedAt, UpdatedAt) values ('Emergency Department (ER)', 'Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti.', 1, 0, '7/27/2025', '4/13/2025'); insert into Departments (Name, Description, OrderIndex, IsActive, CreatedAt, UpdatedAt) values ('Cardiology', 'Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius.  Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi.  Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus.', 30, 0, '1/3/2022', '10/25/2014'); insert into Departments (Name, Description, OrderIndex, IsActive, CreatedAt, UpdatedAt) values ('Neurology', 'Aenean lectus. Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum.  Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est.', 41, 1, '10/2/2017', '2/5/2023'); insert into Departments (Name, Description, OrderIndex, IsActive, CreatedAt, UpdatedAt) values ('Orthopedics', 'Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero.  Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh.', 29, 0, '5/7/2024', '1/5/2017'); insert into Departments (Name, Description, OrderIndex, IsActive, CreatedAt, UpdatedAt) values ('Pediatrics', 'Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh.  In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet.', 48, 0, '11/6/2022', '11/17/2019'); insert into Departments (Name, Description, OrderIndex, IsActive, CreatedAt, UpdatedAt) values ('Radiology', 'Cras non velit nec nisi vulputate nonummy. Maecenas tincidunt lacus at velit. Vivamus vel nulla eget eros elementum pellentesque.  Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus.  Phasellus in felis. Donec semper sapien a libero. Nam dui.', 25, 1, '7/7/2025', '6/5/2019'); insert into Departments (Name, Description, OrderIndex, IsActive, CreatedAt, UpdatedAt) values ('Oncology', 'Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus.  Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero.', 94, 1, '9/13/2015', '10/9/2021'); ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("TRANCATE TABLE Departments");
        }
    }
}
