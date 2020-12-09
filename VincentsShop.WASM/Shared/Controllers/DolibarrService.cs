using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Xml;
using System.Diagnostics;
using VincentsShop.WASM.Shared.Models;

namespace VincentsShop.WASM.Shared.Controllers
{
    public class DolibarrService : IDolibarrService
    {
        public HttpClient Client { get; }

        public DolibarrService(HttpClient client)
        {
            //client.BaseAddress = new Uri("http://michaelccote.com/");
            //client.BaseAddress = new Uri("https://michaelccote.com/");
            client.BaseAddress = new Uri("http://35.188.247.150/");
            //client.BaseAddress = new Uri("https://35.188.247.150/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("DOLAPIKEY", "042965975922d6b74b6cf4105fdf85d71e513f77");

            Client = client;
        }

        public async Task<Category[]> GetCategoriesAsync()
        {
            Category[] categories = null;
            HttpResponseMessage response;
            try
            {
                response = await Client.GetAsync("/api/index.php/categories?type=product");
            }
            catch (Exception)
            {

                throw;
            }

            if (response.IsSuccessStatusCode)
            {
                //Console.WriteLine(await response.Content.ReadAsStringAsync());
                categories = await response.Content.ReadAsAsync<Category[]>();
                foreach (Category category in categories)
                {
                    category.produits = await GetProductsFromCategoryAsync(category.id);
                }
            }
            return categories.Where(x => x.label.ToLower() != "cantine").ToArray();
        }

        private async Task<Product[]> GetProductsFromCategoryAsync(uint catId)
        {
            Product[] products = new Product[0];
            HttpResponseMessage response;
            try
            {
                response = await Client.GetAsync("/api/index.php/categories/" + catId + "/objects?type=product");
            }
            catch (Exception)
            {

                throw;
            }

            if (response.IsSuccessStatusCode)
            {
                //Console.WriteLine(await response.Content.ReadAsStringAsync());
                products = await response.Content.ReadAsAsync<Product[]>();
                foreach (Product product in products)
                {
                    product.image = await GetProductImageAsync(product.id);
                }
            }
            return products;
        }
        private async Task<Product.Image> GetProductImageAsync(uint prodId)
        {
            Product.Image[] image = null;
            HttpResponseMessage response;
            try
            {
                response = await Client.GetAsync("/api/index.php/documents?modulepart=product&id=" + prodId);
            }
            catch (Exception)
            {

                throw;
            }

            if (response.IsSuccessStatusCode)
            {
                //Console.WriteLine(await response.Content.ReadAsStringAsync());
                image = await response.Content.ReadAsAsync<Product.Image[]>();
            }
            return image?.FirstOrDefault();
        }

        public async Task<Usager[]> GetUsersAsync()
        {
            Usager[] usagers = null;
            HttpResponseMessage response;
            try
            {
                response = await Client.GetAsync("/api/index.php/users");
            }
            catch (Exception)
            {

                throw;
            }

            if (response.IsSuccessStatusCode)
            {
                //Console.WriteLine(await response.Content.ReadAsStringAsync());
                usagers = await response.Content.ReadAsAsync<Usager[]>();
            }
            return usagers;
        }

        public async Task<LoginResponse> PostLoginAsync(Usager usager)
        {
            HttpResponseMessage response;
            LoginResponse loginResult = null;
            try
            {
                //var json = JsonSerializer.Serialize(usager, new JsonSerializerOptions() { WriteIndented = true });
                var json = JsonSerializer.Serialize(usager);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                response = await Client.PostAsync("/api/index.php/login", data);
            }
            catch (Exception)
            {

                throw;
            }

            if (response.IsSuccessStatusCode)
            {
                //Console.WriteLine(await response.Content.ReadAsStringAsync());
                try
                {
                    //Debug.WriteLine(await response.Content.ReadAsStringAsync());
                    loginResult = await response.Content.ReadAsAsync<LoginResponse>();
                }
                catch (Exception)
                {

                    throw;
                }

                //usager
            }
            return loginResult;
        }

        public async Task<Company> GetCompanyInfoAsync()
        {
            Company company = null;
            HttpResponseMessage response;
            try
            {
                response = await Client.GetAsync("/api/index.php/setup/company");
            }
            catch (Exception)
            {

                throw;
            }

            if (response.IsSuccessStatusCode)
            {
                //Console.WriteLine(await response.Content.ReadAsStringAsync());
                company = await response.Content.ReadAsAsync<Company>();
            }
            return company;
        }

        public async Task<ThirdParty[]> GetClientsAsync()
        {
            ThirdParty[] clients = null;
            HttpResponseMessage response;
            try
            {
                response = await Client.GetAsync("/api/index.php/thirdparties?sortfield=t.rowid&sortorder=DESC&mode=1");
            }
            catch (Exception)
            {

                throw;
            }

            if (response.IsSuccessStatusCode)
            {
                //Console.WriteLine(await response.Content.ReadAsStringAsync());
                clients = await response.Content.ReadAsAsync<ThirdParty[]>();
            }
            return clients;
        }
        public async Task<ThirdParty[]> GetAllClientsAsync()
        {
            ThirdParty[] clients = null;
            HttpResponseMessage response;
            try
            {
                response = await Client.GetAsync("/api/index.php/thirdparties?sortfield=t.rowid&sortorder=DESC");
            }
            catch (Exception)
            {

                throw;
            }

            if (response.IsSuccessStatusCode)
            {
                //Console.WriteLine(await response.Content.ReadAsStringAsync());
                clients = await response.Content.ReadAsAsync<ThirdParty[]>();
            }
            return clients;
        }

        public async Task<ThirdParty[]> GetFournisseursAsync()
        {
            ThirdParty[] fournisseurs = null;
            HttpResponseMessage response;
            try
            {
                response = await Client.GetAsync("/api/index.php/thirdparties?mode=4");
            }
            catch (Exception)
            {

                throw;
            }

            if (response.IsSuccessStatusCode)
            {
                //Console.WriteLine(await response.Content.ReadAsStringAsync());
                fournisseurs = await response.Content.ReadAsAsync<ThirdParty[]>();
            }
            return fournisseurs;
        }

        public async Task<bool> PostThirdPartyAsync(ThirdParty thirdParty)
        {
            HttpResponseMessage response;

            try
            {
                ThirdParty[] clients = await GetClientsAsync();
                String code_client = (clients[0].@code_client);
                decimal ajout = decimal.Parse(code_client.Substring(code_client.Length - 3));
                ajout = ajout + 1;
                code_client = code_client.Substring(0, 9) + ajout.ToString();
                thirdParty.code_client = code_client;
                var json = JsonSerializer.Serialize(thirdParty);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                response = await Client.PostAsync("/api/index.php/thirdparties", data);
            }
            catch (Exception)
            {

                throw;
            }
            //Console.WriteLine(await response.Content.ReadAsStringAsync());
            return response.IsSuccessStatusCode;
        }



        public async Task<Order[]> GetOrdersAsync(ThirdParty thirdParty)
        {
            Order[] commandes = null;
            HttpResponseMessage response;
            try
            {
                response = await Client.GetAsync("/api/index.php/orders?thirdparty_ids=" + thirdParty.@ref);
            }
            catch (Exception)
            {

                throw;
            }

            if (response.IsSuccessStatusCode)
            {
                //Console.WriteLine(await response.Content.ReadAsStringAsync());
                commandes = await response.Content.ReadAsAsync<Order[]>();
            }
            return commandes;
        }

        public async Task<bool> PostOrderAsync(Order order)
        {
            HttpResponseMessage response;

            try
            {
                var json = JsonSerializer.Serialize(order);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                //Console.WriteLine(await data.ReadAsStringAsync());
                response = await Client.PostAsync("/api/index.php/orders", data);
            }
            catch (Exception)
            {

                throw;
            }
            //Console.WriteLine(await response.Content.ReadAsStringAsync());
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> PostUserAsync(Usager user)
        {
            HttpResponseMessage response;

            try
            {
                var json = JsonSerializer.Serialize(user);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                Console.WriteLine(await data.ReadAsStringAsync());
                response = await Client.PostAsync("/api/index.php/users", data);
            }
            catch (Exception)
            {

                throw;
            }
            //Console.WriteLine(await response.Content.ReadAsStringAsync());
            return response.IsSuccessStatusCode;
        }

        public async Task<Contact[]> GetAllContactsAsync()
        {
            Contact[] contacts = null;
            HttpResponseMessage response;
            try
            {
                response = await Client.GetAsync("/api/index.php/contacts");
            }
            catch (Exception)
            {

                throw;
            }

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(await response.Content.ReadAsStringAsync());
                contacts = await response.Content.ReadAsAsync<Contact[]>();
            }
            return contacts;
        }

        public async Task<bool> PostContactAsync(Contact contact)
        {
            HttpResponseMessage response;

            try
            {
                var json = JsonSerializer.Serialize(contact);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                Console.WriteLine(await data.ReadAsStringAsync());
                response = await Client.PostAsync("/api/index.php/contacts", data);
            }
            catch (Exception)
            {

                throw;
            }
            Console.WriteLine(await response.Content.ReadAsStringAsync());
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> PostCreateUserFromContactAsync(Contact contact,Usager usager)
        {
            HttpResponseMessage response;
            usager.SetSelfRights();
            try
            {
                var json = JsonSerializer.Serialize(usager);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                Console.WriteLine(await data.ReadAsStringAsync());
                response = await Client.PostAsync($"/api/index.php/contacts/{contact.id}/createUser", data);
            }
            catch (Exception)
            {

                throw;
            }
            Console.WriteLine(await response.Content.ReadAsStringAsync());
            return response.IsSuccessStatusCode;
        }




    }
}
