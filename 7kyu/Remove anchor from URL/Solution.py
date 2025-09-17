def remove_url_anchor(url):
    try:
        i = url.index('#')
        return url[:i]
    except ValueError:
        return url