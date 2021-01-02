import wget, requests, os
from bs4 import BeautifulSoup


# TODO
# sayfadaki tüm yazıları alıcak ve bir txt dosyasına kaydedicek
# pdf olarak indirmeyecek yani
# p h1 h2 a'taglerinin içindeki textleri

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
    with open(book_name + ".txt", "r", encoding="utf-8") as file:
        for line in file:
            for word in line.split():
                words.append(word.lower())

        for word in words:
            if word not in words2:
                words2.append(word)

        for word in words2:
            print(word + " " + str(words.count(word)))


# TODO kelimeleri büyükten küçüğe sırala tekrar sayılarına göre
# bunun için kelimeyi ve kelime.countunu 2d li listte tutabilirsin belki

# TODO stop wordsleri ignore edecek
def main():
    download_book(book_name)
    word_freq_single(book_name)


headers = {
    'Access-Control-Allow-Origin': '*',
    'Access-Control-Allow-Methods': 'GET',
    'Access-Control-Allow-Headers': 'Content-Type',
    'Access-Control-Max-Age': '3600',
    'User-Agent': 'Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:52.0) Gecko/20100101 Firefox/52.0'
}
print("Please enter a book name (Case sensitive): ", end="")
book_name = input()
main()
