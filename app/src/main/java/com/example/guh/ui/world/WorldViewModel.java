package com.example.guh.ui.world;

import androidx.lifecycle.LiveData;
import androidx.lifecycle.MutableLiveData;
import androidx.lifecycle.ViewModel;

public class WorldViewModel extends ViewModel {

    private MutableLiveData<String> mText;

    public WorldViewModel() {
        mText = new MutableLiveData<>();
        mText.setValue("This is the world fragment");
    }

    public LiveData<String> getText() {
        return mText;
    }
}