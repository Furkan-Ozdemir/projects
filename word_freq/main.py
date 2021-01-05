import wget, requests, os
from bs4 import BeautifulSoup



def download_book(book_name):
    url = "https://en.wikibooks.org/wiki/" + book_name
    req = requests.get(url, headers)
    soup = BeautifulSoup(req.content, 'html.parser')
    # pdf_link = "https://" + soup.find("a", class_="internal").get("href")
    # print("Downloaded books are saved in " + os.getcwd())
    # wget.download(pdf_link, os.getcwd())
    # page = soup.find(["p","li","h2"])
    # li_tags = soup.find_all("li")
    main_page = soup.find("div", class_="mw-parser-output")
    page = main_page.find_all(["p", "li", "h2"])
    all_text = []
    for i in page:
        all_text.append(i.text)

    with open(book_name + ".txt", "w", encoding="utf-8") as file:
        file.writelines(all_text)
    print("The books was saved to " + os.getcwd() + " as " + book_name + ".txt")


def word_freq_single(book_name):
    words = []  # aynı kelimeler var
    words2 = []  # aynı kelimeler yok
    print("Book Name : " + book_name)
    with open(book_name + ".txt", "r", encoding="utf-8") as file:
        for line in file:
            for word in line.split():
                words.append(word.lower())

        for word in words:
            if word not in words2:
                words2.append(word)

        for word in words2:
            print(word + " " + str(words.count(word)))




# TODO stop wordsleri ignore edecek
# Todo kaç kelime göstermek istediğini soracak
# TODO Outputu düzenle
#todo kitap isimleri First Aid , Latin , Algorithms , Chess

def main():
    if book_number == 1:
        download_book(book_name)
        word_freq_single(book_name)
    elif book_number == 2:
        download_book(book_name)
        download_book(book_name2)
        word_freq_single(book_name)
        print("#######################################")
        word_freq_single(book_name2)


headers = {
    'Access-Control-Allow-Origin': '*',
    'Access-Control-Allow-Methods': 'GET',
    'Access-Control-Allow-Headers': 'Content-Type',
    'Access-Control-Max-Age': '3600',
    'User-Agent': 'Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:52.0) Gecko/20100101 Firefox/52.0'
}
print("How many books do you want to download: (type 1 or 2 ) :  ")
book_number = int(input())
book_name2 = ""
if book_number == 1:
    print("Please enter a book name (Case sensitive): ", end="")
    book_name = input()
    main()
elif book_number == 2:
    print("Please enter the first books name(Case sensitive): ", end="")
    book_name = input()
    print("Please enter the second books name(Case sensitive): ", end="")
    book_name2 = input()
    main()
