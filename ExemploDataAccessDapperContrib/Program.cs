

/*Lembrar de instalar os Packages/Pacotes "Microsoft.Data.SqlClient", "Dapper", "Dapper.Contrib" */

using ExemploDataAccessDapperContrib.Models;
using ExemploDataAccessDapperContrib.Repositories;

CategoryRepository categoryRepository = new CategoryRepository();
RoleRepository roleRepository = new RoleRepository();
TagRepository tagRepository = new TagRepository();
UserRepository userRepository = new UserRepository();

var categoria = new Category()
{
    Name = "Backend",
    Slug = "backend"
};

var role = new Role()
{
    Name = "Autor new",
    Slug = "authorNew"
};

var tag = new Tag()
{
    Name = "VB.NET",
    Slug = "VisualBasic"
};

var user = new User()
{
    Bio = "Equipe balta.io",
    Email = "hello@balta.io",
    Image = "https://...",
    Name = "Equipe balta.io",
    PasswordHash = "HASH",
    Slug = "equipe-balta"
};



//InsertCategory(categoria);
//UpdateCategory(categoria);
//DeleteCategory(2);
//SelectCategoryId(1);
//SelectListCategory();

//InsertRole(role);
//UpdateRole(role);
//DeleteRole(4);
//SelectRoleId(1);
//SelectListRole();

//InsertTag(tag);
//UpdateTag(tag);
//DeleteTag(2);
//SelectTagId(1);
//SelectListTag();

//InsertUser(user);
//UpdateUser(user);
//DeleteUser(8);
//SelectUserId(1);
//SelectListUser();

// ---------------------------------------------------------- CRUD CATEGORY --------------------------------------------------------------------------
void InsertCategory(Category category)
{
    var returnInsertCategory = categoryRepository.InsertCategory(category);

    if (returnInsertCategory > 0)
        Console.WriteLine("Categoria inserida com sucesso!!!");
    else 
        Console.WriteLine("Não foi possivel inserir a categoria!");
}

void UpdateCategory(Category category)
{
    category.Id = 2;
    category.Name = "BackEnd new";
    var returnUpdateCategory = categoryRepository.UpdateCategory(category);

    if (returnUpdateCategory == true)
        Console.WriteLine("Categoria alterada com sucesso!!!");
    else
        Console.WriteLine("Não foi possivel alterar a categoria!");
}

void DeleteCategory(int id)
{
    var returnDeleteCategory = categoryRepository.DeleteCategory(id);

    if (returnDeleteCategory == true)
        Console.WriteLine("Categoria excluida com sucesso!!!");
    else
        Console.WriteLine("Não foi possivel excluir a categoria!");
}

void SelectListCategory()
{
    var returnSelectListCategory = categoryRepository.SelectListCategory();

    foreach (var category in returnSelectListCategory)
        Console.WriteLine($"{category.Id} - {category.Name}");
}

void SelectCategoryId(int id)
{
    var returnSelectCategoryId = categoryRepository.SelectCategory(id);

    Console.WriteLine($"{returnSelectCategoryId.Id} - {returnSelectCategoryId.Name}");
}

// ---------------------------------------------------------- CRUD ROLE --------------------------------------------------------------------------

void InsertRole(Role role)
{
    var returnInsertRole = roleRepository.InsertRole(role);

    if (returnInsertRole > 0)
        Console.WriteLine("Role inserido com sucesso!!!");
    else
        Console.WriteLine("Não foi possivel inserir a Role!");
}

void UpdateRole(Role role)
{
    role.Id = 4;
    role.Name = "Autor novo";
    var returnUpdateRole = roleRepository.UpdateRole(role);

    if (returnUpdateRole == true)
        Console.WriteLine("Role alterada com sucesso!!!");
    else
        Console.WriteLine("Não foi possivel alterar a Role!");
}

void DeleteRole(int id)
{
    var returnDeleteRole = roleRepository.DeleteRole(id);

    if (returnDeleteRole == true)
        Console.WriteLine("Role excluida com sucesso!!!");
    else
        Console.WriteLine("Não foi possivel excluir a Role!");
}

void SelectListRole()
{
    var returnSelectListRole = roleRepository.SelectListRole();

    foreach (var role in returnSelectListRole)
        Console.WriteLine($"{role.Id} - {role.Name}");
}

void SelectRoleId(int id)
{
    var returnSelectRoleId = roleRepository.SelectRole(id);

    Console.WriteLine($"{returnSelectRoleId.Id} - {returnSelectRoleId.Name}");
}

// ---------------------------------------------------------- CRUD TAG --------------------------------------------------------------------------

void InsertTag(Tag tag)
{
    var returnInsertTag = tagRepository.InsertTag(tag);

    if (returnInsertTag > 0)
        Console.WriteLine("Tag inserido com sucesso!!!");
    else
        Console.WriteLine("Não foi possivel inserir a Tag!");
}

void UpdateTag(Tag tag)
{
    tag.Id = 2;
    tag.Name = "VB.NET new";
    var returnUpdateTag = tagRepository.UpdateTag(tag);

    if (returnUpdateTag == true)
        Console.WriteLine("Tag alterada com sucesso!!!");
    else
        Console.WriteLine("Não foi possivel alterar a Tag!");
}

void DeleteTag(int id)
{
    var returnDeleteTag = tagRepository.DeleteTag(id);

    if (returnDeleteTag == true)
        Console.WriteLine("Tag excluida com sucesso!!!");
    else
        Console.WriteLine("Não foi possivel excluir a Tag!");
}

void SelectListTag()
{
    var returnSelectListTag = tagRepository.SelectListTag();

    foreach (var tag in returnSelectListTag)
        Console.WriteLine($"{tag.Id} - {tag.Name}");
}

void SelectTagId(int id)
{
    var returnSelectTagId = tagRepository.SelectTag(id);

    Console.WriteLine($"{returnSelectTagId.Id} - {returnSelectTagId.Name}");
}

// ---------------------------------------------------------- CRUD USER --------------------------------------------------------------------------

void InsertUser(User user)
{
    var returnInsertUser = userRepository.InsertUser(user);

    if (returnInsertUser > 0)
        Console.WriteLine("User inserido com sucesso!!!");
    else
        Console.WriteLine("Não foi possivel inserir a User!");
}

void UpdateUser(User user)
{
    user.Id = 8;
    user.Name = "New balta.io";
    var returnUpdateUser = userRepository.UpdateUser(user);

    if (returnUpdateUser == true)
        Console.WriteLine("User alterada com sucesso!!!");
    else
        Console.WriteLine("Não foi possivel alterar a User!");
}

void DeleteUser(int id)
{
    var returnDeleteUser = userRepository.DeleteUser(id);

    if (returnDeleteUser == true)
        Console.WriteLine("User excluida com sucesso!!!");
    else
        Console.WriteLine("Não foi possivel excluir a User!");
}

void SelectListUser()
{
    var returnSelectListUser = userRepository.SelectListUser();

    foreach (var user in returnSelectListUser)
        Console.WriteLine($"{user.Id} - {user.Name}");
}

void SelectUserId(int id)
{
    var returnSelectUserId = userRepository.SelectUser(id);

    Console.WriteLine($"{returnSelectUserId.Id} - {returnSelectUserId.Name}");
}