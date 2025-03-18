import tkinter as tk

def tombol_ditekan(angka):
    entry.insert(tk.END, angka)

def hitung():
    try:
        hasil = eval(entry.get())
        entry.delete(0, tk.END)
        entry.insert(tk.END, hasil)
    except:
        entry.delete(0, tk.END)
        entry.insert(tk.END, "Error")

root = tk.Tk()
root.title("Kalkulator")

entry = tk.Entry(root, font=("Arial", 20), width=15, borderwidth=5)
entry.grid(row=0, column=0, columnspan=4)

tombol = [
    ('7', 1, 0), ('8', 1, 1), ('9', 1, 2),
    ('4', 2, 0), ('5', 2, 1), ('6', 2, 2),
    ('1', 3, 0), ('2', 3, 1), ('3', 3, 2),
    ('0', 4, 0), ('+', 4, 1), ('=', 4, 2)
]

for (text, row, col) in tombol:
    tk.Button(root, text=text, font=("Arial", 20), command=lambda t=text: tombol_ditekan(t)).grid(row=row, column=col, sticky="nsew")

tk.Button(root, text="=", font=("Arial", 20), command=hitung).grid(row=4, column=2, sticky="nsew")

root.mainloop()
