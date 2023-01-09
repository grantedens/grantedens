#browser in python
import tkinter as tk
import webbrowser

class Browser:
    def __init__(self, root):
        self.root = root
        root.title("Simple Browser")

        # Create the frames
        self.top_frame = tk.Frame(root)
        self.bottom_frame = tk.Frame(root)

        # Create the URL entry bar
        self.url_entry = tk.Entry(self.top_frame)
        self.url_entry.pack(side="left")

        # Create the Go button
        self.go_button = tk.Button(self.top_frame, text="Go", command=self.go)
        self.go_button.pack(side="left")

        # Create the Back button
        self.back_button = tk.Button(self.bottom_frame, text="Back", command=self.back)
        self.back_button.pack(side="left")

        # Create the Forward button
        self.forward_button = tk.Button(self.bottom_frame, text="Forward", command=self.forward)
        self.forward_button.pack(side="left")

        # Create the Refresh button
        self.refresh_button = tk.Button(self.bottom_frame, text="Refresh", command=self.refresh)
        self.refresh_button.pack(side="left")

        # Pack the frames
        self.top_frame.pack()
        self.bottom_frame.pack()

        # Set the starting URL
        self.url = "https://www.google.com"

    def go(self):
        # Get the URL from the entry bar
        self.url = self.url_entry.get()
        # Open the URL in the web browser
        webbrowser.open(self.url)

    def back(self):
        # Go back in the web browser history
        webbrowser.back()

    def forward(self):
        # Go forward in the web browser history
        webbrowser.forward()

    def refresh(self):
        # Refresh the current page in the web browser
        webbrowser.open(self.url)

root = tk.Tk()
browser = Browser(root)
root.mainloop()
